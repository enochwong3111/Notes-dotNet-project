using NotesApp;
using System;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        //for debug usage
        private bool testMode = Boolean.Parse(AppConfig.ReadSetting("testMode"));

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideApp();
            }
        }

        private void ShowApp()
        {
            if (testMode)
            {
                return;
            }
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void HideApp()
        {
            if (testMode)
            {
                return;
            }
            Hide();
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowApp();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApp();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (testMode)
            {
                return;
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                HideApp();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
