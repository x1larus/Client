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
        private Socket Sock;
        public SocketCommunication(string Addr, int Port)
        {
            Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPAddr = new IPEndPoint(IPAddress.Parse(Addr), Port);
            Sock.Connect(IPAddr);
            if (!Sock.Connected)
            {
                //error to GUI
            }
        }
        public int SendToServer(string Message)
        {
            byte[] Buffer = new byte[256];
            Buffer = Encoding.Unicode.GetBytes(Message);
            return Sock.Send(Buffer);
        }

        private void ReciveFromServer()
        {
            while (true)
            {
                byte[] Buffer = new byte[256];
                int Bytes = Sock.Receive(Buffer);
                string Message = Encoding.Unicode.GetString(Buffer, 0, Bytes);
                //EvLoop.AddTask("parse", Message);
            }
        }
    }
}
