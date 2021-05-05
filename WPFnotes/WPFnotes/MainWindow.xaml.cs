using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Collections;
using WPFnotes.Models;

namespace WPFnotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<PromptModels> prompts;

        public MainWindow()
        {
            InitializeComponent();
            Content = new HomePage();

            using (NoteContext db = new NoteContext())
                prompts = db.Prompts.Where(n => n.Push == true && n.ExpirationDate >= DateTime.Now).ToList();
            foreach (var prompt in prompts)
            {
                new ToastContentBuilder()
                    .AddText("Напоминание")
                    .AddText(prompt.TextPrompt)
                    .AddText(prompt.CreationDate.ToString())
                    .Schedule(prompt.ExpirationDate);
            }
        }
    }
}
