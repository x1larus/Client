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
        public const int MAX = 1024;
        private Socket Sock;
        private Thread RecvThr;
        private EvLoop Loop;
        private MainForm MainFormAddress;

        public SocketCommunication(string Addr, int Port)
        {
            Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPAddr = new IPEndPoint(IPAddress.Parse(Addr), Port);
            Sock.Connect(IPAddr);
            if (!Sock.Connected)
            {
                //error to GUI
            }
            RecvThr = new Thread(ReceiveFromServer);
            RecvThr.Start();
            return;
        }

        public void SetLoopAddress(EvLoop a)
        {

        }

        public int SendToServer(string Message)
        {
            byte[] Buffer = new byte[256];
            Buffer = Encoding.Unicode.GetBytes(Message);
            return Sock.Send(Buffer);
        }

        private void ReceiveFromServer()
        {
            while (true)
            {
                byte[] Buffer = new byte[256];
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
