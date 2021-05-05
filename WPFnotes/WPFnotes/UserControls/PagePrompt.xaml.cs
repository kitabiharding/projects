using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFnotes.Models;

namespace WPFnotes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для PagePrompt.xaml
    /// </summary>
    public partial class PagePrompt : UserControl
    {
        private PromptModels Prompt;

        public PagePrompt(PromptModels prompt)
        {
            InitializeComponent();
            Prompt = prompt;
            tbTextPrompt.Text = Prompt.TextPrompt;
            tbCreationDate.Text = Prompt.CreationDate.ToString();
            tbExpirationDate.Text = Prompt.ExpirationDate.ToString();
            tbTagsPrompt.Text = Prompt.TagsPrompt;
            cbPush.IsChecked = Prompt.Push;                
        }

        private void PromptBack_Click(object sender, RoutedEventArgs e)
        {
            Content = new HomePage(1);
        }

        private void PromptDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить напоминание?", "notes", MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                using (NoteContext db = new NoteContext())
                {
                    PromptModels promptModel = db.Prompts.Where(n => n.ID == Prompt.ID).FirstOrDefault();

                    db.Prompts.Remove(promptModel);
                    db.SaveChanges();
                }
            }

            Content = new HomePage(1);
        }
    }
}
