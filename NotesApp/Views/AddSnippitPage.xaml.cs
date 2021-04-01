using System;
using System.IO;

using NotesApp.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp.Views
    {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSnippitPage : ContentPage
        {
        public AddSnippitPage()
            {
            InitializeComponent();
            BindingContext = new Snippit();
            }

        private void LoadSnippit(string snippitName)
            {
            var snippit = new Snippit
                {
                Name = snippitName
                };

            BindingContext = snippit;
            }

        private void OnSaveButtonClicked(object sender, EventArgs e)
            {
            var snippit = new Snippit();

            if (string.IsNullOrWhiteSpace(snippit.Name))
                //Check if file already exists
                if (string.IsNullOrWhiteSpace(snippit.Name))
                    {
                    string _fileName = Path.Combine(Environment.GetFolderPath(), snippit);
                    }
            }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
            {
            }
        }
    }