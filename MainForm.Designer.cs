namespace LockKeysIcons
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
            this.components = new System.ComponentModel.Container();
            this.notifyIconNumLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconCapsLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconScrollLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripAll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToStartupAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconNumLock
            // 
            this.notifyIconNumLock.Text = "notifyIcon1";
            this.notifyIconNumLock.Visible = true;
            this.notifyIconNumLock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconNumLock_MouseClick);
            // 
            // notifyIconCapsLock
            // 
            this.notifyIconCapsLock.Text = "notifyIcon1";
            this.notifyIconCapsLock.Visible = true;
            this.notifyIconCapsLock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconCapsLock_MouseClick);
            // 
            // notifyIconScrollLock
            // 
            this.notifyIconScrollLock.Text = "notifyIcon1";
            this.notifyIconScrollLock.Visible = true;
            this.notifyIconScrollLock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconScrollLock_MouseClick);
            // 
            // contextMenuStripAll
            // 
            this.contextMenuStripAll.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToStartupAppsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripAll.Name = "contextMenuStripAll";
            this.contextMenuStripAll.Size = new System.Drawing.Size(217, 52);
            // 
            // addToStartupAppsToolStripMenuItem
            // 
            this.addToStartupAppsToolStripMenuItem.Name = "addToStartupAppsToolStripMenuItem";
            this.addToStartupAppsToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.addToStartupAppsToolStripMenuItem.Text = "Add To Startup Apps";
            this.addToStartupAppsToolStripMenuItem.Click += new System.EventHandler(this.addToStartupAppsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.contextMenuStripAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconNumLock;
        private System.Windows.Forms.NotifyIcon notifyIconCapsLock;
        private System.Windows.Forms.NotifyIcon notifyIconScrollLock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAll;
        private System.Windows.Forms.ToolStripMenuItem addToStartupAppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

