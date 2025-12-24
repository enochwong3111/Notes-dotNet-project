using System;
using System.Windows.Forms;

namespace NotesApp.Controls
{
    public partial class NoteListSearch : UserControl
    {
        bool isClear;
        NoteList noteList;
        public NoteList NoteList
        {
            get
            {
                return noteList;
            }
            set
            {
                if (noteList == null)
                {
                    noteList = value;
                }
                else
                {
                    throw new ArgumentException("Value exist!");
                }
            }
        }
        public string SearchText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public bool SelectAll
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

        public NoteListSearch()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == checkBox1)
            {
                noteList.UpdateListItemSelection(checkBox1.Checked);
            }
        }

        public void OnListItemSelectionChange(bool hasSelection)
        {
            linkLabelDelete.Enabled = hasSelection;
        }

        private void linkLabelDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var actionStr = isClear ? "clear" : "delete";
            var result = MessageBox.Show($"Are you sure to {actionStr} selected note(s)?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                noteList.RemoveSelectedNotes(isClear);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                noteList.ListNote(textBox1.Text);
            }
        }
    }
}
