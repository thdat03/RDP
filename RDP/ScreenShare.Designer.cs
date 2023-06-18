namespace RDP
{
    partial class ScreenShare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenShare));
            this.axRDPViewer = new AxRDPCOMAPILib.AxRDPViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Option = new System.Windows.Forms.ToolStripMenuItem();
            this.ChatClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ChatServer = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axRDPViewer
            // 
            this.axRDPViewer.Enabled = true;
            this.axRDPViewer.Location = new System.Drawing.Point(0, 27);
            this.axRDPViewer.Name = "axRDPViewer";
            this.axRDPViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRDPViewer.OcxState")));
            this.axRDPViewer.Size = new System.Drawing.Size(1878, 1009);
            this.axRDPViewer.TabIndex = 0;
            this.axRDPViewer.Enter += new System.EventHandler(this.axRDPViewer_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Option});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Option
            // 
            this.Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChatClient,
            this.ChatServer});
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(69, 24);
            this.Option.Text = "Option";
            // 
            // ScreenShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.axRDPViewer);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScreenShare";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenShare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxRDPCOMAPILib.AxRDPViewer axRDPViewer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Option;
        private System.Windows.Forms.ToolStripMenuItem ChatClient;
        private System.Windows.Forms.ToolStripMenuItem ChatServer;
    }
}