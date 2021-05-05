using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFnotes.Models;

namespace WPFnotes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для PageTags.xaml
    /// </summary>
    public partial class PageTags : UserControl
    {
        TagsModels elmTag;
        private BindingList<NoteModels> _noteElmList;
        private BindingList<PromptModels> _promptElmList;

        public PageTags(TagsModels tag)
        {
            InitializeComponent();
            elmTag = tag;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string nameNote;
            _noteElmList = new BindingList<NoteModels>();
            _promptElmList = new BindingList<PromptModels>();

            using (NoteContext db = new NoteContext())
            {
                var noteElmList = db.Notes.ToList();
                var promptElmList = db.Prompts.ToList();

                foreach (var note in noteElmList)
                {
                    if (note.TagsNote == elmTag.NameTags)
                    {
                        if (note.NameNote == "")
                            nameNote = note.TextNote.Substring(0, Math.Min(note.TextNote.Length, 50)).Replace("\r\n", " ").Replace("\r", "");
                        else
                            nameNote = note.NameNote;

                        _noteElmList.Add(new NoteModels() { ID = note.ID, CreationDate = note.CreationDate, NameNote = nameNote, TextNote = note.TextNote, TagsNote = note.TagsNote });
                    }

                }

                foreach (var prompt in promptElmList)
                {
                    if (prompt.TagsPrompt == elmTag.NameTags)
                        _promptElmList.Add(new PromptModels { ID = prompt.ID, CreationDate = prompt.CreationDate, ExpirationDate = prompt.ExpirationDate, Push = prompt.Push, TextPrompt = prompt.TextPrompt, TagsPrompt = prompt.TagsPrompt });
                }
            }

            tbNameTag.Text = elmTag.NameTags;
            dgNotes.ItemsSource = _noteElmList;
            dgPrompts.ItemsSource = _promptElmList;
        }

        private void dgNotes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Content = new TextNote(_noteElmList[dgNotes.SelectedIndex]);
        }

        private void dgPrompt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Content = new PagePrompt(_promptElmList[dgPrompts.SelectedIndex]);
        }

        private void TagDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_noteElmList.Count + _promptElmList.Count != 0)
            {
                var result = MessageBox.Show("Удалить все элементы, соответствующие тегу?", "notes", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    using (NoteContext db = new NoteContext())
                    {
                        var noteElmList = db.Notes.ToList();
                        var promptElmList = db.Prompts.ToList();

                        foreach (var note in _noteElmList)
                            db.Notes.Remove(db.Notes.Where(n => n.ID == note.ID).FirstOrDefault());

                        foreach (var prompt in _promptElmList)
                            db.Prompts.Remove(db.Prompts.Where(n => n.ID == prompt.ID).FirstOrDefault());

                        db.SaveChanges();
                    }
                }
                else
                {
                    using (NoteContext db = new NoteContext())
                    {
                        var noteElmList = db.Notes.ToList();
                        var promptElmList = db.Prompts.ToList();

                        foreach (var note in _noteElmList)
                        {
                            var noteModel = db.Notes.Where(n => n.ID == note.ID).FirstOrDefault();
                            noteModel.TagsNote = "";
                        }

                        foreach (var prompt in _promptElmList)
                        {
                            var promptModel = db.Prompts.Where(n => n.ID == prompt.ID).FirstOrDefault();
                            promptModel.TagsPrompt = "";
                        }

                        db.SaveChanges();
                    }
                }
            }
            using (NoteContext db = new NoteContext())
            {
                db.Tags.Remove(db.Tags.Where(n => n.ID == elmTag.ID).FirstOrDefault());
                db.SaveChanges();
            }
            Content = new HomePage(2);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Content = new HomePage(2);
        }
    }
}
