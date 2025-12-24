using System;
using System.Drawing;
using System.Reflection;

using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        //SoundPlayer alarmSound;

        readonly string timeFormat = AppConfig.ReadSetting("timeFormat");
        readonly string fontFamily = AppConfig.ReadSetting("fontFamily");
        readonly float fontSize = Convert.ToSingle(AppConfig.ReadSetting("fontSize"));
        //string noteListFilePath = "./note.txt";
        Font defaultFont;

        bool IsAlarmSet
        {
            get
            {
                return checkBox1.Checked;
            }
            set
            {
                checkBox1.Checked = value;
            }
        }
        DateTime AlarmTime
        {
            get
            {
                return dateTimePicker.Value;
            }
        }

        // If the form have some heavy workload function, use this timer instead, isolate the timer event from form 'UI' running
        //System.Timers.Timer sysTimer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();
            InitializeNoteListObject();
            Timer1.Start();
            //can add .wmv, .mp3 file in bin folder
            //alarmSound = new SoundPlayer("sound.mp3");
            //notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            labelVerVal.Text = version;
            defaultFont = new Font(fontFamily, fontSize);
            testToolStripMenuItem.Visible = testMode;

            //for debug use
            propertyGrid1.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var curTime = DateTime.Now;
            //Console.WriteLine($"Form curent Time: {curTime}");
            labelCurrentTimeTxt.Text = DateTime.Now.ToString(timeFormat);
            if (IsAlarmSet && curTime >= AlarmTime)
            {
                //alarmSound.Play();
                IsAlarmSet = false;
                MessageBox.Show("Times up!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            CheckInProgressReminders();
        }
    }
}
