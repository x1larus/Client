
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChatLog
            // 
            this.ChatLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(42)))));
            this.ChatLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChatLog.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChatLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(148)))));
            this.ChatLog.Location = new System.Drawing.Point(-2, 0);
            this.ChatLog.Margin = new System.Windows.Forms.Padding(0);
            this.ChatLog.Multiline = true;
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.ReadOnly = true;
            this.ChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatLog.Size = new System.Drawing.Size(860, 535);
            this.ChatLog.TabIndex = 0;
            this.ChatLog.TextChanged += new System.EventHandler(this.ChatLog_TextChanged);
            // 
            // MsgEnterBox
            // 
            this.MsgEnterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(75)))), ((int)(((byte)(63)))));
            this.MsgEnterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgEnterBox.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsgEnterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(218)))), ((int)(((byte)(148)))));
            this.MsgEnterBox.Location = new System.Drawing.Point(31, 557);
            this.MsgEnterBox.Margin = new System.Windows.Forms.Padding(10);
            this.MsgEnterBox.Multiline = true;
            this.MsgEnterBox.Name = "MsgEnterBox";
            this.MsgEnterBox.Size = new System.Drawing.Size(595, 46);
            this.MsgEnterBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(163)))), ((int)(((byte)(123)))));
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(639, 557);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(189, 46);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OnlineLable
            // 
            this.OnlineLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.OnlineLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnlineLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(161)))), ((int)(((byte)(152)))));
            this.OnlineLable.Location = new System.Drawing.Point(858, 0);
            this.OnlineLable.Margin = new System.Windows.Forms.Padding(0);
            this.OnlineLable.Name = "OnlineLable";
            this.OnlineLable.Size = new System.Drawing.Size(315, 56);
            this.OnlineLable.TabIndex = 3;
            this.OnlineLable.Text = "В СЕТИ";
            this.OnlineLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OnlineLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // OnlineUsers
            // 
            this.OnlineUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.OnlineUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnlineUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.OnlineUsers.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnlineUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(121)))));
            this.OnlineUsers.Location = new System.Drawing.Point(858, 56);
            this.OnlineUsers.Margin = new System.Windows.Forms.Padding(0);
            this.OnlineUsers.Multiline = true;
            this.OnlineUsers.Name = "OnlineUsers";
            this.OnlineUsers.ReadOnly = true;
            this.OnlineUsers.Size = new System.Drawing.Size(315, 577);
            this.OnlineUsers.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(10, 537);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 84);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MainForm
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1171, 631);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MsgEnterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OnlineUsers);
            this.Controls.Add(this.OnlineLable);
            this.Controls.Add(this.ChatLog);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(100)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Chat by x1larus";
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
        private System.Windows.Forms.Label label1;
    }
}