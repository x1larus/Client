using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Client
{
    public partial class LoginForm : Form
    {
        private EvLoop Loop;
        public delegate void SuccesfulLogin();
        public SuccesfulLogin SuccesfulLoginDelegate;

        public LoginForm(EvLoop a)
        {
            InitializeComponent();
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("font.ttf"); // файл шрифта
            FontFamily family = fontCollection.Families[0];
            // Создаём шрифт и используем далее
            Font font = new Font(family, 20);

            //задача шрифтов
            LoginButton.Font = font;
            AuthorizationLabel.Font = font;

            ErrorLabel.Visible = false;
            Loop = a;
            Loop.LoginGUI = this;
            SuccesfulLoginDelegate = new SuccesfulLogin(SuccesfulLoginMethod);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            String Login = LoginBox.Text;
            String Password = PassBox.Text;
            if (Login.Length == 0 || Password.Length == 0)
            {
                ErrorLabel.Text = "Введите логин и/или пароль";
                ErrorLabel.Visible = true;
                PassBox.Clear();
                return;
            }
            Dictionary<string, string> Args = new Dictionary<string, string>();
            Args["TYPE"] = "login";
            Args["LOGIN"] = Login;
            Args["PASSWORD"] = Password;
            Loop.AddTask("SendToServer", Args);
        }

        private void SuccesfulLoginMethod()
        {
            Close();
            return;
        }
    }
}
