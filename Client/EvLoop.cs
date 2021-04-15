using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Client
{
    public class EvLoop
    {
        private Queue<Tuple<string, Dictionary<string, string>>> TaskQueue;
        private ManualResetEvent Wait;
        private static object QueueLock;
        public Thread LoopThr;
        private MainForm GUI;
        public LoginForm LoginGUI;
        private SocketCommunication Sender;
        private bool IsActive;

        public EvLoop()
        {
            IsActive = true;
            TaskQueue = new Queue<Tuple<string, Dictionary<string, string>>>();
            Wait = new ManualResetEvent(false);
            QueueLock = new object();
            LoopThr = new Thread(Loop);
            LoopThr.Start();
            return;
        }

        public void SetSenderAddress(SocketCommunication a)
        {
            Sender = a;
            return;
        }

        public void SetFormAddress(MainForm a)
        {
            GUI = a;
            return;
        }

        public void AddTask(string Cmd, Dictionary<string, string> Args)
        {
            Tuple<string, Dictionary<string, string>> Temp = new Tuple<string, Dictionary<string, string>>(Cmd, Args);
            lock (QueueLock)
            {
                TaskQueue.Enqueue(Temp);
            }
            Wait.Set();
            return;
        }

        public void Loop()
        {
            while (IsActive)
            {
                lock (QueueLock)
                {
                    if (TaskQueue.Count != 0)
                        Wait.Set();
                }
                Wait.WaitOne();
                Tuple<string, Dictionary<string, string>> Temp;
                lock (QueueLock)
                {
                    Temp = TaskQueue.Dequeue();
                }
                //tasks
                switch (Temp.Item1)
                {
                    case "RecvParse":
                        RecvParser(Temp.Item2);
                        break;
                    case "global":
                        GlobalChatNewMsg(Temp.Item2);
                        break;
                    case "SendToServer":
                        BuildRequest(Temp.Item2);
                        break;
                    case "SystemError":
                        ErrorToGUI(Temp.Item2);
                        break;
                    case "exit":
                        IsActive = false;
                        BuildRequest(Temp.Item2);
                        Sender.RecvThr.Join();
                        return;
                    case "auth":
                        if (Temp.Item2["AUTH"] == "true")
                        {
                            LoginGUI.Invoke(LoginGUI.SuccesfulLoginDelegate);
                        }
                        break;
                    case "online":
                        ParseOnlineUsers(Temp.Item2);
                        break;
                }

                Wait.Reset();
            }
        }

        private void RecvParser(Dictionary<string, string> Args)
        {
            string Request;
            if (!Args.TryGetValue("request", out Request))
                return;
            Dictionary<string, string> Result = new Dictionary<string, string>();
            bool IsValue = false;
            string Key = "", Value = "";
            for (int i = 0; i < Request.Length; i++)
            {
                if ((Request[i] == '=' || Request[i] == ';') && !IsValue)
                    continue;
                if (Request[i] == '.' && !IsValue)
                    break;
                if (Request[i] == '<' && !IsValue)
                {
                    IsValue = true;
                    continue;
                }
                if (Request[i] == '>' && Request[i+1] ==';')
                {
                    Result.Add(Key, Value);
                    Key = "";
                    Value = "";
                    IsValue = false;
                    continue;
                }
                //default
                if (IsValue)
                    Value = Value.Insert(Value.Length, Request[i].ToString());
                else
                    Key = Key.Insert(Key.Length, Request[i].ToString());
            }
            string Cmd;
            if (!Result.TryGetValue("TYPE", out Cmd))
                return;
            AddTask(Cmd, Result);
            return;
        }

        private void GlobalChatNewMsg(Dictionary<string, string> Args)
        {
            GUI.Invoke(GUI.GlobalMsgDelegate, new object[] { Args });
            return;
        }

        private void BuildRequest(Dictionary<string, string> Args)
        {
            string Request = "";
            foreach(var Current in Args)
            {
                Request += Current.Key + "=<" + Current.Value + ">;";
            }
            Request += '.';
            Sender.SendToServer(Request);
            return;
        }

        private void ErrorToGUI(Dictionary<string, string> Args)
        {
            GUI.Invoke(GUI.ErrorDelegate, new object[] { Args["ERROR"] });
            return;
        }

        private void ParseOnlineUsers(Dictionary<string, string> Args)
        {
            string Users = Args["ONLINE"];
            if (Users.Length == 0)
                return;
            string Temp = "";
            List<string> List = new List<string>();
            foreach (var x in Users)
            {
                if (x == '>')
                {
                    List.Add(Temp);
                    Temp = "";
                    continue;
                }
                if (x == '<')
                    continue;
                Temp += x;
            }
            GUI.Invoke(GUI.RefreshOnlineUsersDelegate, new object[] { List });
            return;
        }
    }
}
