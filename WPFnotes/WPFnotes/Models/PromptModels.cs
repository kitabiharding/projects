using System;
using System.Collections.Generic;
using System.Text;

namespace WPFnotes.Models
{
    public class PromptModels
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Push { get; set; }
        public string TextPrompt { get; set; }
        public string TagsPrompt { get; set; }
    }
}
