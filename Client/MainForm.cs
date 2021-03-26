using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        private SocketCommunication Sender;
        private EvLoop Loop;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Sender = new SocketCommunication("", 1488);
            Loop = new EvLoop();
            Loop.SetSenderAddress(Sender);
            Sender.SetLoopAddress(Loop);
        }
    }
}
