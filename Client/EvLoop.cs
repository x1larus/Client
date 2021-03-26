using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Client
{
    public class EvLoop
    {
        private Queue<Tuple<string, List<string>>> TaskQueue;
        private ManualResetEvent Wait;
        private static object QueueLock;
        private Thread LoopThr;
        private MainForm MainFormAddress;
        private SocketCommunication SenderAddress;

        public EvLoop()
        {
            TaskQueue = new Queue<Tuple<string, List<string>>>();
            Wait = new ManualResetEvent(false);
            QueueLock = new object();
            LoopThr = new Thread(Loop);
            LoopThr.Start();
        }

        public void SetSenderAddress(SocketCommunication a)
        {
            SenderAddress = a;
            return;
        }

        public void AddTask(string Cmd, List<string> Args)
        {
            Tuple<string, List<string>> Temp = new Tuple<string, List<string>>(Cmd, Args);
            lock (QueueLock)
            {
                TaskQueue.Enqueue(Temp);
            }
            Wait.Set();
            return;
        }

        private void Loop()
        {
            while (true)
            {
                lock (QueueLock)
                {
                    if (TaskQueue.Count != 0)
                        Wait.Set();
                }
                Wait.WaitOne();
                Tuple<string, List<string>> Temp;
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
                }

                Wait.Reset();
            }
        }

        private void RecvParser(List<string> Args)
        {
            string Request = Args[0];
        }
    }
}
