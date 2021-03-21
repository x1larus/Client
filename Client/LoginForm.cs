using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ErrorLabel.Visible = false;
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
        }
    }
}
