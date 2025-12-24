using NotesApp.Controls;
using NotesApp.DBService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1
    {
        int selectedTabIndex = 0;

        public static readonly Dictionary<Priority, Bitmap> PriorityImgMap = new Dictionary<Priority, Bitmap>()
        {
            {Priority.Low, Properties.Resources.low},
            {Priority.Medium, Properties.Resources.medium},
            {Priority.High, Properties.Resources.high}
        };

        private void InitializeNoteListObject()
        {
            noteListDraft.FilterStatus = NoteStatus.Draft;
            noteListInProgress.FilterStatus = NoteStatus.InProgress;
            noteListDone.FilterStatus = NoteStatus.Done;
            noteListDeleted.FilterStatus = NoteStatus.Deleted;
            ListNote(0);
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            FormNote newNoteDialog = new FormNote(null);
            if (newNoteDialog.ShowDialog(this) == DialogResult.OK)
            {
                var note = newNoteDialog.GetNote();
                note.Id = NoteService.AddNote(note);
                if (selectedTabIndex == (int)NoteStatus.Draft)
                {
                    noteListDraft.AddNote(note);
                }
                //JsonSerialization.WriteToJsonFile<List<Note>>(noteListFilePath, noteList);
            }
            newNoteDialog.Dispose();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTabIndex = tabControl2.SelectedIndex;
            ListNote(selectedTabIndex);
        }

        private void ListNote(int listTabIndex)
        {
            var list = tabControl2.Controls[listTabIndex].Controls[0] as NoteList;
            list.ListNote();
        }

        void CheckInProgressReminders()
        {
            var list = NoteService.GetInprogressNote();
            foreach (var note in list)
            {
                var remindTime = note.RemindTime;
                if (note.Type == RemiderType.EveryDay)
                {
                    note.RemindTime = remindTime.AddDays((DateTime.Now - remindTime).Days + 1);
                }
                else
                {
                    note.Reminded = true;
                }
                NoteService.UpdateNote(note);
                if (note.Type == RemiderType.Once)
                {
                    //use remindTime to cal postpone time
                    MessageBox.Show($"Note Reminder: {note.Subject}", note.Content, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    //use remindTime to cal postpone time
                    MessageBox.Show($"Note Reminder: {note.Subject}", note.Content, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            //update inprogress list if also mark done
        }
    }
}
