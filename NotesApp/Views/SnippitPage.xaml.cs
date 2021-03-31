using System;
using System.IO;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp.Views
    {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SnippitPage : ContentPage
        {
        //Save Notes in local file - > Inside CodeBehind Contentpage.xaml
        //To reach data outside of it's own environment we have to save in in the sandbox.
        //
        // Access the file in the sandbox like this:
        private readonly string _filename =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public SnippitPage()
            {
            InitializeComponent();

            //Read the file
            if (File.Exists(_filename)) Editor.Text = File.ReadAllText(_filename);
            }

        private async Task WhenSaveButtonClicked()
            {
            File.WriteAllText(_filename, Editor.Text);
            }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
            {
            await WhenSaveButtonClicked();
            }

        private async Task WhenDeleteButtonClicked()
            {
            if (File.Exists(_filename)) File.Delete(_filename);

            Editor.Text = string.Empty;
            }

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
            {
            await WhenDeleteButtonClicked();
            }
        }
    }