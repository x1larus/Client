using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SocketCommunication Sender = new SocketCommunication();
            EvLoop Loop = new EvLoop();
            Sender.SetLoopAddress(Loop);
            Loop.SetSenderAddress(Sender);
            Sender.Connect("172.20.146.136", 3333); //fuck yeah
            Application.Run(new MainForm(Loop));
        }
    }
}
