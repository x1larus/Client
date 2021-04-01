using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    
    public class SocketCommunication
    {
        public const int MAX = 4096;
        private Socket Sock;
        private Thread RecvThr;
        private EvLoop Loop;

        public SocketCommunication()
        {
            Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            return;
        }

        public bool Connect(string Addr, int Port)
        {
            IPEndPoint IPAddr = new IPEndPoint(IPAddress.Parse(Addr), Port);
            Sock.Connect(IPAddr);
            if (!Sock.Connected)
            {
                return false;
            }
            RecvThr = new Thread(ReceiveFromServer);
            RecvThr.Start();
            return true;
        }

        public void SetLoopAddress(EvLoop a)
        {
            Loop = a;
            return;
        }

        public int SendToServer(string Message)
        {
            byte[] Buffer = new byte[MAX];
            Buffer = Encoding.Unicode.GetBytes(Message);
            if (!Sock.Connected)
            {
                Dictionary<string, string> Args = new Dictionary<string, string>();
                Args.Add("ERROR", "no connection to server");
                Loop.AddTask("SystemError", Args);
                return -1;
            }
            return Sock.Send(Buffer);
        }

        private void ReceiveFromServer()
        {
            while (true)
            {
                byte[] Buffer = new byte[MAX];
                if (!Sock.Connected)
                    continue;
                int Bytes = Sock.Receive(Buffer);
                if (Bytes == 0)
                    continue;
                string Request = Encoding.Unicode.GetString(Buffer, 0, Bytes);
                Dictionary<string, string> Temp = new Dictionary<string, string>();
                Temp.Add("request", Request);
                Loop.AddTask("RecvParse", Temp);
            }
        }
    }
}
