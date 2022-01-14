using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecForYou
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridInGridPage();
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
