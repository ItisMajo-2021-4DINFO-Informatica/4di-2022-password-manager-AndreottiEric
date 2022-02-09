using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class App : Application
    {
        public static string NoteDatabase { get; set; }

        public App()
        {
            InitializeComponent();
            NoteDatabase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}