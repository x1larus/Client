using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    public partial class MainForm : Form
    {
        private SocketCommunication Sender;
        private EvLoop Loop;
        public MainForm(SocketCommunication a, EvLoop b)
        {
            Sender = a;
            Loop = b;
            Sender.SetFormAddress(this);
            Loop.SetFormAddress(this);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string Message = MsgEnterBox.Text;
            if (Message.Length == 0)
                return;
            MsgEnterBox.Clear();
        }

        public void AddNewGlobalMsg(Dictionary<string, string> Args)
        {
            string Line, Sender, Msg;
            if (!Args.TryGetValue("SENDER", out Sender) || !Args.TryGetValue("MSG", out Msg))
                return;
            Line = "[" + Sender + "]: " + Msg;
            ChatLog.Text += Line + "\n";
        }
    }
}
