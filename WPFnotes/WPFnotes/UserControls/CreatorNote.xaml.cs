using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFnotes.Models;

namespace WPFnotes
{
    /// <summary>
    /// Логика взаимодействия для CreatorNote.xaml
    /// </summary>
    public partial class CreatorNote : UserControl
    {
        private List<string> _tagsList;

        public CreatorNote()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _tagsList = new List<string>();
            using (NoteContext db = new NoteContext())
            {
                var tagElmList = db.Tags.ToList();

                foreach (var tag in tagElmList)
                {
                    _tagsList.Add(tag.NameTags);
                }
            }

            cbTagsNote.ItemsSource = _tagsList;
        }

        private void CreateNewNote_Click(object sender, RoutedEventArgs e)
        {
            if (tbTextNote.Text == "")
                MessageBox.Show("Попытка создать пустую заметку.", "notes", MessageBoxButton.OK);
            else
            {
                using (NoteContext db = new NoteContext())
                {
                    NoteModels noteModels = new NoteModels { CreationDate = DateTime.Now, NameNote = tbNameNote.Text, TextNote = tbTextNote.Text, TagsNote = cbTagsNote.Text };
                    db.Notes.Add(noteModels);
                    db.SaveChanges();
                }
                Content = new HomePage();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Content = new HomePage();
        }
    }
}
