using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFnotes.Models;

namespace WPFnotes
{
    /// <summary>
    /// Логика взаимодействия для CreatorPrompt.xaml
    /// </summary>
    public partial class CreatorPrompt : UserControl
    {
        private List<string> _tagsList;

        public CreatorPrompt()
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

            cbTagsPrompt.ItemsSource = _tagsList;
        }

        private void CreateNewPrompt_Click(object sender, RoutedEventArgs e)
        {
            DateTime date;
            bool push;

            if (tbTextPrompt.Text == "")
                MessageBox.Show("Попытка создать пустое напоминание.", "notes", MessageBoxButton.OK);
            else if (!DateTime.TryParse(tbExpirationDate.Text, out _) && tbExpirationDate.Text != "")
                MessageBox.Show("Неверный формат ввода времени.", "notes", MessageBoxButton.OK);
            else if (tbExpirationDate.Text != "" && DateTime.Parse(tbExpirationDate.Text) < DateTime.Now)
                MessageBox.Show("Напоминание не может быть задано в прошедшем времени.", "notes", MessageBoxButton.OK);
            else
            {
                if (rbPush.IsChecked == true)
                    push = true;
                else
                    push = false;
                if (tbExpirationDate.Text == "")
                    date = DateTime.Now.AddMinutes(10);
                else date = DateTime.Parse(tbExpirationDate.Text);
                using (NoteContext db = new NoteContext())
                {
                    PromptModels promptModels = new PromptModels { CreationDate = DateTime.Now, ExpirationDate = date, Push = push, TextPrompt = tbTextPrompt.Text, TagsPrompt = cbTagsPrompt.Text};
                    db.Prompts.Add(promptModels);
                    db.SaveChanges();

                    if (push)
                        new ToastContentBuilder()
                            .AddText("Напоминание")
                            .AddText(promptModels.TextPrompt)
                            .AddText(promptModels.CreationDate.ToString())
                            .Schedule(promptModels.ExpirationDate);
                }
                Content = new HomePage(1);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Content = new HomePage(1);
        }
    }
}
