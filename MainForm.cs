using System;
using System.IO;
using System.Windows.Forms;
using static LockKeysIcons.Tools;

namespace LockKeysIcons
{
    public partial class MainForm : Form
    {
        private bool showForm = false; // Controls the hiding of the form -> keep for later dev eg settings menu
        private readonly string shortcutPath; // Path to LNK file

        // Constructor
        public MainForm()
        {
            InitializeComponent();

            shortcutPath = Environment.ExpandEnvironmentVariables(
                @"%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\LockKeysIcons.lnk"
            );

            // Add the context menu strip to all buttons
            notifyIconNumLock.ContextMenuStrip = contextMenuStripAll;
            notifyIconCapsLock.ContextMenuStrip = contextMenuStripAll;
            notifyIconScrollLock.ContextMenuStrip = contextMenuStripAll;

            if (File.Exists(shortcutPath)) // Remove if already linked to startup files
                contextMenuStripAll.Items.Remove(addToStartupAppsToolStripMenuItem);

            timer1_Tick(null, EventArgs.Empty); // Initial update for icons
        }

        // Quit the application
        void Exit()
        {
            Application.Exit();
            Environment.Exit(0);
        }


        // --------- GUI ---------

        // Hide the form
        protected override void SetVisibleCore(bool value) => base.SetVisibleCore(showForm ? value : false);

        // If form needs to show
        public void ShowForm()
        {
            showForm = true;
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        // Context menu strip
        private void addToStartupAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CreateShortcut(
                    shortcutPath: shortcutPath,
                    targetPath: Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LockKeysIcons.exe"),
                    workingDirectory: AppDomain.CurrentDomain.BaseDirectory,
                    description: "Launch LockKeysIcons"
                );

                MessageBox.Show($"Added to startup at path: {shortcutPath}!");

                contextMenuStripAll.Items.Remove(addToStartupAppsToolStripMenuItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding to startup programs failed: " + ex.Message);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }


        // Clicking the icons
        private void notifyIconNumLock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Let context menu show naturally
            }
            else if (e.Button == MouseButtons.Left) Exit();
        }
        private void notifyIconCapsLock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Let context menu show naturally
            }
            else if (e.Button == MouseButtons.Left) Exit();
        }
        private void notifyIconScrollLock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Let context menu show naturally
            }
            else if (e.Button == MouseButtons.Left) Exit();
        }

        // Update the icons
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsKeyLocked(Keys.NumLock))
            {
                notifyIconNumLock.Icon = Properties.Resources.NumLockON;
                notifyIconNumLock.Text = "ON"; // Hover text
            }
            else
            {
                notifyIconNumLock.Icon = Properties.Resources.NumLockOFF;
                notifyIconNumLock.Text = "OFF";
            }

            if (IsKeyLocked(Keys.CapsLock))
            {
                notifyIconCapsLock.Icon = Properties.Resources.CapsLockON;
                notifyIconCapsLock.Text = "ON";
            }
            else
            {
                notifyIconCapsLock.Icon = Properties.Resources.CapsLockOFF;
                notifyIconCapsLock.Text = "OFF";
            }

            if (IsKeyLocked(Keys.Scroll))
            {
                notifyIconScrollLock.Icon = Properties.Resources.ScrollLockON;    
                notifyIconScrollLock.Text = "ON";
            }
            else
            {
                notifyIconScrollLock.Icon = Properties.Resources.ScrollLockOFF;
                notifyIconScrollLock.Text = "OFF";
            }
        }
    }
}
