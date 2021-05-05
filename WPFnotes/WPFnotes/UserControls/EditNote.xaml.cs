using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFnotes.Models;

namespace WPFnotes
{
    /// <summary>
    /// Логика взаимодействия для EditNote.xaml
    /// </summary>
    public partial class EditNote : UserControl
    {
        private List<string> _tagsList;
        public NoteModels noteModels;

        public EditNote(NoteModels note)
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

            InitializeComponent();
            tbNameNote.Text = note.NameNote;
            cbTagsNote.SelectedItem = note.TagsNote;
            tbTextNote.Text = note.TextNote;
            noteModels = note;

            cbTagsNote.ItemsSource = _tagsList;
        }

        private void NoteSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbTagsNote.Text == "")
                cbTagsNote.Text = "не задано";
            if (tbNameNote.Text != noteModels.NameNote || tbTextNote.Text != noteModels.TextNote || cbTagsNote.Text != noteModels.TagsNote)
            {
                using (NoteContext db = new NoteContext())
                {
                    NoteModels noteModel = db.Notes.Where(n => n.ID == noteModels.ID).FirstOrDefault();

                    if (tbNameNote.Text != noteModels.NameNote)
                        noteModel.NameNote = tbNameNote.Text;

                    if (tbTextNote.Text != noteModels.TextNote)
                        noteModel.TextNote = tbTextNote.Text;

                    if (cbTagsNote.Text != noteModels.TagsNote)
                        noteModel.TagsNote = cbTagsNote.Text;

                    noteModel.CreationDate = DateTime.Now;

                    db.SaveChanges();
                }

                MessageBoxResult result = MessageBox.Show("Изменения успешно сохранены", "notes", MessageBoxButton.OK);
            }

            Content = new HomePage();
        }
    }
}
