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
        private EvLoop Loop;
        public delegate void Error(string Error);
        public Error ErrorDelegate;
        public delegate void GlobalMsg(Dictionary<string, string> Args);
        public GlobalMsg GlobalMsgDelegate;
        public MainForm(EvLoop b)
        {
            this.FormClosing += MainForm_FormClosing;
            Loop = b;
            Loop.SetFormAddress(this);
            InitializeComponent();
            ErrorDelegate = new Error(ErrorMethod);
            GlobalMsgDelegate = new GlobalMsg(GlobalMsgMethod);
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm LoginGUI = new LoginForm(Loop);
            LoginGUI.Show();
            this.Hide();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string Message = MsgEnterBox.Text;
            if (Message.Length == 0)
                return;
            MsgEnterBox.Clear();
            Dictionary<string, string> Args = new Dictionary<string, string>();
            Args.Add("TYPE", "global");
            Args.Add("RECIEVERS", "all");
            Args.Add("MSG", Message);
            Loop.AddTask("SendToServer", Args);
            return;
        }

        public void GlobalMsgMethod(Dictionary<string, string> Args)
        {
            string Line, Sender, Msg;
            if (!Args.TryGetValue("SENDER", out Sender) || !Args.TryGetValue("MSG", out Msg))
                return;
            Line = "[" + Sender + "]: " + Msg;
            ChatLog.AppendText(Line + "\r" + "\n");
            return;
        }

        public void ErrorMethod(string Error)
        {
            ChatLog.AppendText("[SYSTEM]: " + Error + "\r" + "\n");
            return;
        }
        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Dictionary<string, string> Args = new Dictionary<string, string>();
            Args["TYPE"] = "logout";
            Loop.AddTask("exit", Args);
            Loop.LoopThr.Join();
            return;
        }

        private void ChatLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
