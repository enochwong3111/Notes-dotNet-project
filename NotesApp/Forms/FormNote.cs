using System;
using System.Windows.Forms;
using NotesApp.DBService;

namespace NotesApp
{
    public partial class FormNote : Form
    {
        //bool reminded = false;
        Note note;

        public FormNote(Note note)
        {
            InitializeComponent();
            if (note != null) {
                Subject = note.Subject;
                Content = note.Content;
                Type = note.Type;
                ReminderTime = note.RemindTime;
                Priority = note.Priority;
                //reminded = note.Reminded;
                this.note = note;
            }
        }

        private string Subject {  
            get {
                return textBox1.Text;
            }
            set { 
                textBox1.Text = value;
            }
        }

        private string Content
        {
            get
            {
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
            }
        }

        private RemiderType Type
        {
            get
            {
                if (radioButton1.Checked)
                {
                    return RemiderType.None;
                }
                else if (radioButton2.Checked)
                {
                    return RemiderType.Once;
                }
                else
                {
                    return RemiderType.EveryDay;
                }
            }
            set
            {
                switch (value)
                {
                    case RemiderType.Once: 
                        radioButton2.Checked = true;
                        //dateTimePicker1.Enabled = true; //todo test needed or not
                        break;
                    case RemiderType.EveryDay:
                        radioButton3.Checked = true;
                        //dateTimePicker2.Enabled = true;
                        break;
                    case RemiderType.None:
                    default:
                        radioButton1.Checked = true;
                        break;
                }
            }
        }

        private DateTime ReminderTime
        { 
            get 
            { 
                switch (Type)
                {
                    case RemiderType.None:
                        return DateTime.MinValue;
                    case RemiderType.Once:
                        return dateTimePicker1.Value;
                    case RemiderType.EveryDay:
                        return dateTimePicker2.Value;
                }
                return DateTime.MinValue;
            }
            set
            {
                switch (Type)
                {
                    case RemiderType.None:
                        return;
                    case RemiderType.Once:
                    case RemiderType.EveryDay:
                        dateTimePicker1.Value = value;
                        dateTimePicker2.Value = value;
                        break;
                }
            }

        }
        
        private Priority Priority
        {
            get
            {
                if (radioButton4.Checked)
                {
                    return Priority.High;
                }
                else if (radioButton5.Checked)
                {
                    return Priority.Medium;
                } else
                {
                    return Priority.Low;
                }
            }
            set
            {
                switch (value)
                {
                    case Priority.High:
                        radioButton4.Checked = true;
                        break;
                    case Priority.Medium:
                        radioButton5.Checked = true;
                        //dateTimePicker2.Enabled = true;
                        break;
                    case Priority.Low:
                    default:
                        radioButton6.Checked = true;
                        break;
                }
            }
        }
        
        public void UpdateNote()
        {
            if (note != null)
            {
                note.Subject = Subject;
                note.Content = Content;
                note.Priority = Priority;
                note.Type = Type;
                if (note.Status == NoteStatus.InProgress)
                {
                    if (note.Type == RemiderType.Once)
                    {
                        if (ReminderTime > DateTime.Now)
                        {
                            note.Reminded = false;
                        }
                    }
                    else if (note.Type == RemiderType.EveryDay)
                    {
                        note.Reminded = false;
                        if (ReminderTime <= DateTime.Now)
                        {
                            ReminderTime = ReminderTime.AddDays((DateTime.Now - ReminderTime).Days + 1);
                        }
                        else if (ReminderTime.AddDays(-1) > DateTime.Now)
                        {
                            ReminderTime = ReminderTime.AddDays(-1);
                        }
                    }
                }
                note.RemindTime = ReminderTime;
                NoteService.UpdateNote(note);
            }
        }
        public Note GetNote()
        {
            if (note != null)
            {
                note.Subject = Subject;
                note.Content = Content;
                note.Priority = Priority;
                note.Type = Type;
                note.RemindTime = ReminderTime;
                return note;
            }
            else
            {
                return new Note(Subject, Content, Priority, Type, ReminderTime);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked)
            {
                dateTimePicker1.Enabled = false;
            } else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton3.Checked)
            {
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker2.Enabled = true;
            }
        }
    }
}
