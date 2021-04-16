
namespace Client
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginPic = new System.Windows.Forms.PictureBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PassPic = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPic
            // 
            this.LoginPic.Image = global::Client.Properties.Resources.login1;
            this.LoginPic.Location = new System.Drawing.Point(12, 79);
            this.LoginPic.Name = "LoginPic";
            this.LoginPic.Size = new System.Drawing.Size(64, 64);
            this.LoginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPic.TabIndex = 0;
            this.LoginPic.TabStop = false;
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(75)))), ((int)(((byte)(63)))));
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(148)))));
            this.LoginBox.Location = new System.Drawing.Point(82, 89);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(251, 38);
            this.LoginBox.TabIndex = 1;
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(75)))), ((int)(((byte)(63)))));
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(148)))));
            this.PassBox.Location = new System.Drawing.Point(82, 174);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(251, 38);
            this.PassBox.TabIndex = 3;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // PassPic
            // 
            this.PassPic.Image = global::Client.Properties.Resources.pass1;
            this.PassPic.Location = new System.Drawing.Point(12, 164);
            this.PassPic.Name = "PassPic";
            this.PassPic.Size = new System.Drawing.Size(64, 64);
            this.PassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassPic.TabIndex = 2;
            this.PassPic.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(163)))), ((int)(((byte)(123)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(0, 264);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(345, 58);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthorizationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(121)))));
            this.AuthorizationLabel.Location = new System.Drawing.Point(0, 0);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(345, 60);
            this.AuthorizationLabel.TabIndex = 5;
            this.AuthorizationLabel.Text = "Авторизация";
            this.AuthorizationLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 231);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(321, 34);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(345, 322);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.PassPic);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPic;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.PictureBox PassPic;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}