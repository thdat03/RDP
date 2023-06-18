namespace RDP
{
    partial class Chat
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
            this.txtMessenger = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessenger
            // 
            this.txtMessenger.FormattingEnabled = true;
            this.txtMessenger.ItemHeight = 16;
            this.txtMessenger.Location = new System.Drawing.Point(12, 12);
            this.txtMessenger.Name = "txtMessenger";
            this.txtMessenger.Size = new System.Drawing.Size(459, 292);
            this.txtMessenger.TabIndex = 0;
            this.txtMessenger.SelectedIndexChanged += new System.EventHandler(this.txtMessenger_SelectedIndexChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 371);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(459, 67);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtMessenger);
            this.Name = "ChatServer";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox txtMessenger;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
    }
}