
namespace Client
{
    partial class MainForm
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
            this.ChatLog = new System.Windows.Forms.TextBox();
            this.MsgEnterBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.OnlineLable = new System.Windows.Forms.Label();
            this.OnlineUsers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChatLog
            // 
            this.ChatLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ChatLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChatLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChatLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChatLog.Location = new System.Drawing.Point(1, 0);
            this.ChatLog.Multiline = true;
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.ReadOnly = true;
            this.ChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatLog.Size = new System.Drawing.Size(705, 471);
            this.ChatLog.TabIndex = 0;
            this.ChatLog.TextChanged += new System.EventHandler(this.ChatLog_TextChanged);
            // 
            // MsgEnterBox
            // 
            this.MsgEnterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MsgEnterBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsgEnterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.MsgEnterBox.Location = new System.Drawing.Point(1, 477);
            this.MsgEnterBox.Multiline = true;
            this.MsgEnterBox.Name = "MsgEnterBox";
            this.MsgEnterBox.Size = new System.Drawing.Size(705, 55);
            this.MsgEnterBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(2)))));
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(712, 477);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(291, 55);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Hack";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OnlineLable
            // 
            this.OnlineLable.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnlineLable.ForeColor = System.Drawing.Color.White;
            this.OnlineLable.Location = new System.Drawing.Point(712, 9);
            this.OnlineLable.Name = "OnlineLable";
            this.OnlineLable.Size = new System.Drawing.Size(291, 44);
            this.OnlineLable.TabIndex = 3;
            this.OnlineLable.Text = "Пользователи онлайн";
            this.OnlineLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OnlineLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // OnlineUsers
            // 
            this.OnlineUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OnlineUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnlineUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.OnlineUsers.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnlineUsers.ForeColor = System.Drawing.Color.Gold;
            this.OnlineUsers.Location = new System.Drawing.Point(712, 56);
            this.OnlineUsers.Multiline = true;
            this.OnlineUsers.Name = "OnlineUsers";
            this.OnlineUsers.ReadOnly = true;
            this.OnlineUsers.Size = new System.Drawing.Size(291, 415);
            this.OnlineUsers.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1004, 533);
            this.Controls.Add(this.OnlineUsers);
            this.Controls.Add(this.OnlineLable);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MsgEnterBox);
            this.Controls.Add(this.ChatLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "DarkNet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatLog;
        private System.Windows.Forms.TextBox MsgEnterBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label OnlineLable;
        private System.Windows.Forms.TextBox OnlineUsers;
    }
}