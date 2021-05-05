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
    /// Логика взаимодействия для CreatorTag.xaml
    /// </summary>
    public partial class CreatorTag : UserControl
    {
        public CreatorTag()
        {
            InitializeComponent();
        }

        private void CreateNewTag_Click(object sender, RoutedEventArgs e)
        {
            if (tbNameTag.Text[0] != '#' && tbNameTag.Text[1] != ' ')
                MessageBox.Show("Неверный формат ввода.", "notes", MessageBoxButton.OK);
            else if (tbNameTag.Text.Remove(0, 2) == "")
                MessageBox.Show("Попытка добавить пустой тег.", "notes", MessageBoxButton.OK);
            else
            {
                using (NoteContext db = new NoteContext())
                {
                    TagsModels tagsModels = new TagsModels { NameTags = tbNameTag.Text };
                    db.Tags.Add(tagsModels);
                    db.SaveChanges();
                }
                Content = new HomePage(2);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Content = new HomePage(2);
        }
    }
}
