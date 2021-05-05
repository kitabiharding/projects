using System;

namespace WPFnotes.Models
{
    public class NoteModels
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
        public string NameNote { get; set; }
        public string TextNote { get; set; }
        public string TagsNote { get; set; }
    }
}
