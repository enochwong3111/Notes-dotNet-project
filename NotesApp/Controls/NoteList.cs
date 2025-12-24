using System.Collections.Generic;
using System.Windows.Forms;
using NotesApp.DBService;

namespace NotesApp.Controls
{
    public partial class NoteList : UserControl
    {
        FlowLayoutPanel list;
        string searchStr = "";
        public NoteStatus FilterStatus
        {
            get; set;
        }
        int Total
        {
            get
            {
                return list.Controls.Count;
            }
        }
        int SelectedCnt
        {
            get
            {
                int cnt = 0;
                foreach (NoteListItem item in list.Controls)
                {
                    if (item.Selected) cnt++;
                }
                return cnt;
            }
        }

        public NoteList()
        {
            InitializeComponent();
            listSearch.NoteList = this;
            list = flowLayoutPanelNoteList;
        }

        public void UpdateListItemSelection(bool allSelected)
        {
            foreach (NoteListItem item in list.Controls)
            {
                item.Selected = allSelected;
            }
            TriggerSelectionChangeEvent();
        }

        void Clear()
        {
            list.Controls.Clear();
            TriggerSelectionChangeEvent();
        }

        public void ListNote(string search = "")
        {
            List<Note> noteList;
            Clear();
            listSearch.SearchText = search;
            if (searchStr == search)
            {
                noteList = NoteService.GetNoteList(FilterStatus);
            }
            else
            {
                searchStr = search;
                noteList = NoteService.SearchNotes(FilterStatus, searchStr);
            }

            foreach (var note in noteList)
            {
                AddNote(note);
            }
        }

        public void AddNote(Note note)
        {
            var item = new NoteListItem(note, this);
            list.Controls.Add(item);
        }

        public void TriggerSelectionChangeEvent()
        {
            listSearch.SelectAll = (SelectedCnt == Total && Total != 0);
            listSearch.OnListItemSelectionChange(SelectedCnt > 0);
        }

        public void RemoveSelectedNotes(bool clear)
        {
            var selectedCnt = SelectedCnt;
            if (selectedCnt < 1)
            {
                return;
            }
            var items = new List<int>();
            for (int i = list.Controls.Count - 1; i >= 0; i--)
            {
                var note = list.Controls[i] as NoteListItem;
                if (note.Selected)
                {
                    items.Add(note.Id);
                    list.Controls.Remove(note);
                }
            }
            NoteService.DeleteNote(items.ToArray(), clear);
            TriggerSelectionChangeEvent();
        }
        
    }
}
