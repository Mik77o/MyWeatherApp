using MyWeatherApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitDictionary();
            MainPage = new NavigationPage(new WeatherMainPage());

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

        private void InitDictionary()
        {
            var resources = App.Current.Resources;
        }

    }
}
