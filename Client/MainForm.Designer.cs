
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
            this.SuspendLayout();
            // 
            // ChatLog
            // 
            this.ChatLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ChatLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChatLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChatLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChatLog.Location = new System.Drawing.Point(0, 0);
            this.ChatLog.Multiline = true;
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.ReadOnly = true;
            this.ChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatLog.Size = new System.Drawing.Size(794, 384);
            this.ChatLog.TabIndex = 0;
            this.ChatLog.TextChanged += new System.EventHandler(this.ChatLog_TextChanged);
            // 
            // MsgEnterBox
            // 
            this.MsgEnterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MsgEnterBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MsgEnterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.MsgEnterBox.Location = new System.Drawing.Point(0, 390);
            this.MsgEnterBox.Multiline = true;
            this.MsgEnterBox.Name = "MsgEnterBox";
            this.MsgEnterBox.Size = new System.Drawing.Size(642, 55);
            this.MsgEnterBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(2)))));
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(648, 390);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(140, 55);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Hack";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(794, 450);
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
    }
}