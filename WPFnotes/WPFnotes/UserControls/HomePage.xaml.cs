using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFnotes.Models;
using WPFnotes.UserControls;

namespace WPFnotes
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : UserControl
    {
        private BindingList<NoteModels> _noteElmList;
        private BindingList<TagsModels> _tagElmList;
        private BindingList<PromptModels> _promptElmList;
        int Index;

        public HomePage(int index = 0)
        {
            InitializeComponent();
            Index = index;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string nameNote, tagsNote;
            _noteElmList = new BindingList<NoteModels>();
            _tagElmList = new BindingList<TagsModels>();
            _promptElmList = new BindingList<PromptModels>();

            using (NoteContext db = new NoteContext())
            {
                var noteElmList = db.Notes.ToList();
                var tagElmList = db.Tags.ToList();
                var promptElmList = db.Prompts.ToList();

                foreach (var note in noteElmList)
                {
                    if (note.NameNote == "")
                        nameNote = "(" + note.TextNote.Substring(0, Math.Min(note.TextNote.Length, 50)).Replace("\r\n", " ").Replace("\r", "") + ")";
                    else
                        nameNote = note.NameNote;

                    if (note.TagsNote == "")
                        tagsNote = "не задано";
                    else
                        tagsNote = note.TagsNote;

                    _noteElmList.Add(new NoteModels() { ID = note.ID, CreationDate = note.CreationDate, NameNote = nameNote, TextNote = note.TextNote, TagsNote = tagsNote });
                }

                foreach (var tag in tagElmList)
                {
                    _tagElmList.Add(new TagsModels() { ID = tag.ID, NameTags = tag.NameTags });
                }

                foreach (var prompt in promptElmList)
                {
                    if (prompt.ExpirationDate >= DateTime.Now.AddDays(-1))
                        _promptElmList.Add(new PromptModels { ID = prompt.ID, CreationDate = prompt.CreationDate, ExpirationDate = prompt.ExpirationDate, Push = prompt.Push, TextPrompt = prompt.TextPrompt, TagsPrompt = prompt.TagsPrompt });
                }
            }

            dgNotes.ItemsSource = _noteElmList;
            dgTags.ItemsSource = _tagElmList;
            dgPrompts.ItemsSource = _promptElmList;

            Home.SelectedIndex = Index;
        }

        private void CreateNote_Click(object sender, RoutedEventArgs e)
        {
            Content = new CreatorNote();
        }

        private void CreatePrompt_Click(object sender, RoutedEventArgs e)
        {
            Content = new CreatorPrompt();
        }

        private void CreateTags_Click(object sender, RoutedEventArgs e)
        {
            Content = new CreatorTag();
        }

        private void dgNotes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Content = new TextNote(_noteElmList[dgNotes.SelectedIndex]);
        }

        private void dgPrompt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Content = new PagePrompt(_promptElmList[dgPrompts.SelectedIndex]);
        }

        private void dgTags_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Content = new PageTags(_tagElmList[dgTags.SelectedIndex]);
        }
    }
}
