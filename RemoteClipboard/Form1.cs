using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RemoteClipboard_example
{
    public partial class Form1 : Form
    {
        public Form1() //subscriber
        {
            InitializeComponent();
        }

        #region Variables
        RemoteClipboard remoteClipboard;
        string clipboardtext = null;
        string user = null;
        string yourusername = null;
        bool notificationenabled = true;
        #endregion



        public void OnAddedMessage(object sourse, MessageEventArgs e)
        {
            if (notificationenabled)
            {
                notifyIcon.ShowBalloonTip(5000, e.Message.username + "-Sent a clipboard", e.Message.message, ToolTipIcon.None);
            }
            clipboardtext = e.Message.message;
            user = e.Message.username;
            //Console.WriteLine(e.Message.username + ":" + e.Message.message);
        }

        #region ComponentMethods
        private void Form1_Load(object sender, EventArgs e)
        {
            SetBottomRight();
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            CopyClipboard(clipboardtext);
        }

        private void button_paste_Click(object sender, EventArgs e)
        {
            InstantPaste(clipboardtext,(int)numericUpDown_paste.Value);
        }

        private void button_setusername_Click(object sender, EventArgs e)
        {
            yourusername = textBox_setusername.Text;
            remoteClipboard = new RemoteClipboard(yourusername); //publisher
            remoteClipboard.AddedMessage += OnAddedMessage;
            groupBox_setusername.Visible = false;

            //454; 142
            this.Width = 454;
            this.Height = 142;
            SetBottomRight();
            this.Hide();

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            remoteClipboard.Sender(Clipboard.GetText());
        }

        private void numericUpDown_paste_ValueChanged(object sender, EventArgs e)
        {
            button_paste.Text = "Paste after "+numericUpDown_paste.Value+" seconds";
        }
        #endregion



        #region Notificon&ToolStrip
        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyClipboard(clipboardtext);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstantPaste(clipboardtext,5);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void disableNotificationFor1MinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notificationenabled = false;
            Thread thread = new Thread(TimeChecker);
            thread.IsBackground = true;
            thread.Start();

        }
        #endregion

        

        #region Methods&Thread
        private void CopyClipboard(string text)
        {
            Clipboard.SetText(text);
        }

        private void InstantPaste(string text, int time)
        {
            string tempclip = Clipboard.GetText();
            Clipboard.SetText(clipboardtext);
            SendKeys.Send("%{Tab}");
            Thread.Sleep((int)time * 1000);
            SendKeys.Send("^{v}");
            Clipboard.SetText(tempclip);
        }

        private void SetBottomRight()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
        }

        private void TimeChecker()
        {
            DateTime dateTime = DateTime.Now;
            dateTime = dateTime.Add(new TimeSpan(0, 1, 0));

            while (true)
            {
                if (DateTime.Now.Minute == dateTime.Minute)
                {
                    notificationenabled = true;
                    break;
                }
                Thread.Sleep(1000);
            }

        }
        #endregion
    }
}
