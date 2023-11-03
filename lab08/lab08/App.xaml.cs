using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab08
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BatterDemo();
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
