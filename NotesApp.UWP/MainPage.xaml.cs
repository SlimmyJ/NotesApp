namespace NotesApp.UWP
    {
    public sealed partial class MainPage
        {
        public MainPage()
            {
            this.InitializeComponent();

            LoadApplication(new NotesApp.App());
            }
        }
    }