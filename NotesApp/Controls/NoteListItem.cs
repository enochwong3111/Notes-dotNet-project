using System;
using System.Windows.Forms;
using NotesApp.DBService;

namespace NotesApp.Controls
{
    public partial class NoteListItem : UserControl
    {
        //Note note;
        public int Id
        {
            get; set;
        }
        public bool Selected 
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

        public string Subject
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        NoteList parentList;

        public NoteListItem(Note note, NoteList parent)
        {
            InitializeComponent();
            parentList = parent;
            //this.note = note;
            label1.Text = note.Subject;
            Id = note.Id;

            //Bitmap img;
            //Form1.PriorityMap.TryGetValue(note.Priority, out img);
            pictureBox1.Image = Form1.PriorityImgMap[note.Priority];
            if (!note.Deleted)
            {
                switch (note.Status)
                {
                    case NoteStatus.Draft:
                        //linkLabelEdit.Show();
                        //linkLabelStart.Show();
                        //linkLabelDelete.Show();
                        linkLabelDone.Hide();
                        linkLabelRestore.Hide();
                        linkLabelReturn.Hide();
                        linkLabelClear.Hide();
                        break;
                    case NoteStatus.InProgress:
                        //linkLabelEdit.Show();
                        //linkLabelDelete.Show();
                        //linkLabelDone.Show();
                        linkLabelStart.Hide();
                        linkLabelRestore.Hide();
                        linkLabelReturn.Hide();
                        linkLabelClear.Hide();
                        break;
                    case NoteStatus.Done:
                        //linkLabelDelete.Show();
                        //linkLabelReturn.Show();
                        linkLabelEdit.Hide();
                        linkLabelStart.Hide();
                        linkLabelDone.Hide();
                        linkLabelRestore.Hide();
                        linkLabelClear.Hide();
                        tableLayoutPanel1.ColumnStyles[3].Width = 150F;
                        break;
                        //case NoteStatus.Deleted:
                        //    linkLabelEdit.Hide();
                        //    linkLabelStart.Hide();
                        //    linkLabelDelete.Hide();
                        //    linkLabelDone.Hide();
                        //    linkLabelReturn.Hide();
                        //    //linkLabelRestore.Show();
                        //    //linkLabelClear.Show();
                        //    tableLayoutPanel1.ColumnStyles[3].Width = 150F;
                        //    break;
                }
            }
            else
            {
                linkLabelEdit.Hide();
                linkLabelStart.Hide();
                linkLabelDelete.Hide();
                linkLabelDone.Hide();
                linkLabelReturn.Hide();
                //linkLabelRestore.Show();
                //linkLabelClear.Show();
                tableLayoutPanel1.ColumnStyles[3].Width = 150F;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var note = NoteService.FindNote(Id);
            FormNote noteDialog = new FormNote(note);
            if (noteDialog.ShowDialog(this) == DialogResult.OK)
            {
                noteDialog.UpdateNote();
                Subject = note.Subject;
                pictureBox1.Image = Form1.PriorityImgMap[note.Priority];
                // pass note data back to form1 if write to file is needed
                // JsonSerialization.WriteToJsonFile<List<Note>>(noteListFilePath, noteList);
            }
            noteDialog.Dispose();
        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var note = NoteService.FindNote(Id);
            note.Start();
            NoteService.UpdateNote(note);
            RemoveFromUI();
        }

        private void linkLabelDone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var note = NoteService.FindNote(Id);
            note.Finish();
            NoteService.UpdateNote(note);
            RemoveFromUI();
        }

        private void linkLabelReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var note = NoteService.FindNote(Id);
            note.Start();
            NoteService.UpdateNote(note);
            RemoveFromUI();
        }

        private void linkLabelDelete_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Remove();
        }

        private void linkLabelRestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var note = NoteService.FindNote(Id);
            NoteService.RestoreNote(note);
            RemoveFromUI();
        }

        private void linkLabelClear_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Remove(true);
            parentList.TriggerSelectionChangeEvent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.ActiveControl == checkBox1)
            {
                parentList.TriggerSelectionChangeEvent();
            }
        }

        public void Remove(bool clear = false)
        {
            NoteService.DeleteNote(new int[] { Id }, clear);
            RemoveFromUI();
        }

        void RemoveFromUI()
        {
            this.Parent.Controls.Remove(this);
            parentList.TriggerSelectionChangeEvent();
        }

        /*
        Bitmap GetBitmapFromResouces(Note note)
        {
            var memberInfo = typeof(Priority).GetMember(note.Priority.ToString());
            var customAttribute = (ImgResourceNameAttribute)Attribute.GetCustomAttribute(memberInfo[0], typeof(ImgResourceNameAttribute));
            ResourceManager rm = new ResourceManager("AlarmApp.Properties.Resources", typeof(Program).Assembly);
            Bitmap bmp = (Bitmap)rm.GetObject(customAttribute.Name);
            return bmp;
        }
        */
    }
}
