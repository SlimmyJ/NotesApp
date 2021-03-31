using System;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp.Views
    {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
        {
        public AboutPage()
            {
            InitializeComponent();
            }

        private async void OnButtonLearnMoreClicked(object sender, EventArgs e)
            {
            await Launcher.OpenAsync("https://www.google.be");
            }
        }
    }