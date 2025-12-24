using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace NotesApp.DBService
{
    public static class NoteService
    {
        private static readonly string dbFile = @"Data.db";

        public static List<Note> GetNoteList(NoteStatus status)
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                if (status == NoteStatus.Deleted)
                {
                    return col.Find(x => x.Deleted == true).ToList();
                }
                else
                {
                    return col.Find(x => x.Status == status && x.Deleted == false).ToList();
                }
            }
        }

        public static List<Note> SearchNotes(NoteStatus status, string value)
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                if (status == NoteStatus.Deleted)
                {
                    return col.Find(x => x.Deleted == true && (x.Subject.Contains(value) || x.Content.Contains(value))).ToList();
                }
                else
                {
                    return col.Find(x => x.Status == status && x.Deleted == false && (x.Subject.Contains(value) || x.Content.Contains(value))).ToList();
                }
            }
        }

        public static Note FindNote(int id)
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                return col.FindById(id);
            }
        }

        public static List<Note> GetInprogressNote()
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                return col.Find(x => x.Status == NoteStatus.InProgress && x.Deleted == false && x.Type != RemiderType.None && ((x.Reminded == false && x.RemindTime <= DateTime.Now) || (x.Reminded == true && x.Postponed == true && x.PostponeTime <= DateTime.Now))).ToList();
                //((x.Type == RemiderType.Once && x.Reminded == false) || (x.Type == RemiderType.EveryDay && (x.Reminded == false || (x.Reminded == true && x.LastUpdatedDT < DateTime.Now))))
            }
        }

        public static int AddNote(Note note)
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                note.LastUpdatedDT = DateTime.Now;
                return col.Insert(note).AsInt32;
            }
        }

        public static void RestoreNote(Note note)
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                note.Deleted = false;
                note.LastUpdatedDT = DateTime.Now;
                col.Update(note);
                db.Commit();
            }
        }

        public static void UpdateNote(Note note)
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                note.LastUpdatedDT = DateTime.Now;
                //note.RemindTime = note.RemindTime.AddDays(-3);
                var updated = col.Update(note);
                Console.WriteLine(updated);
                db.Commit();
            }
        }

        public static void DeleteNote(int[] idArr, bool clear = false)
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                var ids = String.Join(",", idArr);
                if (clear)
                {
                    col.DeleteMany($"_id in [{ids}]");
                }
                else
                {
                    col.UpdateMany("{Deleted: true}", $"_id in [{ids}]");
                }
            }
        }

        public static void Clear()
        {
            using (var db = new LiteDatabase(dbFile))
            {
                var col = db.GetCollection<Note>("Note");
                col.DeleteAll();
            }
        }
    }
}
