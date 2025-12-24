using System;
using System.ComponentModel;
using System.Drawing;

namespace NotesApp
{
    public class Note
    {
        public int Id
        {
            get; set;
        }

        public string Subject
        {
            get; set;
        }

        public string Content
        {
            get; set;
        }

        public RemiderType Type
        {
            get; set;
        }

        public DateTime RemindTime
        {
            get; set;
        }

        public bool Reminded
        {
            get; set;
        }

        public bool Postponed
        {
            get; set;
        }

        public DateTime PostponeTime
        {
            get; set;
        }

        public bool Deleted
        {
            get; set;
        }

        public DateTime LastUpdatedDT
        {
            get; set;
        }

        //public Color Color
        //{
        //    get; set;
        //}

        //public bool Marked
        //{
        //    get; set;
        //}

        public NoteStatus Status
        {
            get; set;
        }

        public Priority Priority
        {
            get; set;
        }

        public Note() { }

        public Note(string subject, string content, Priority priority, RemiderType type = RemiderType.None, DateTime remindTime = default)//, Color color = default, bool marked = false
        {
            Subject = subject;
            Content = content;
            Type = type;
            RemindTime = remindTime;
            //Color = color;
            //Marked = marked;
            Reminded = false;
            Status = NoteStatus.Draft;
            Priority = priority;
            Deleted = false;
        }

        public void Start()
        {
            Status = NoteStatus.InProgress;
        }

        public void Finish()
        {
            Status = NoteStatus.Done;
        }

        public void Delete()
        {
            Status = NoteStatus.Deleted;
        }
    }

    public enum RemiderType
    {
        None,
        Once,
        EveryDay
    }

    public enum NoteStatus
    {
        //value to be the tab index
        Deleted = 3,
        Done = 2,
        Draft = 0,
        InProgress = 1
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ImgResourceNameAttribute : Attribute
    {
        public string Name { get; }

        public ImgResourceNameAttribute(string name)
        {
            Name = name;
        }
    }

    public enum Priority
    {
        [ImgResourceName("high")]
        High,

        [ImgResourceName("medium")]
        Medium,

        [ImgResourceName("low")]
        Low

    }
}
