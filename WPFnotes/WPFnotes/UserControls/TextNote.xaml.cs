using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFnotes.Models;

namespace WPFnotes
{
    /// <summary>
    /// Логика взаимодействия для TextNote.xaml
    /// </summary>
    public partial class TextNote : UserControl
    {
        public NoteModels noteModels;

        public TextNote(NoteModels note)
        {
            InitializeComponent();
            tbNameNote.Text = note.NameNote;
            tbCreationDate.Text = note.CreationDate.ToString();
            tbTagsNote.Text = note.TagsNote;
            tbTextNote.Text = note.TextNote;
            noteModels = note;
        }

        private void NoteBack_Click(object sender, RoutedEventArgs e)
        {
            Content = new HomePage();
        }

        private void NoteEdit_Click(object sender, RoutedEventArgs e)
        {
            Content = new EditNote(noteModels);
        }

        private void NoteDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить заметку?", "notes", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    using (NoteContext db = new NoteContext())
                    {
                        NoteModels noteModel = db.Notes.Where(n => n.ID == noteModels.ID).FirstOrDefault();

                        db.Notes.Remove(noteModel);
                        db.SaveChanges();
                    }
                }

                Content = new HomePage();
        }
    }
}
