<<<<<<< HEAD
﻿using MyWeatherApp.Helpers;
using MyWeatherApp.Models;
=======
﻿using MyWeatherApp.Models;
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
using MyWeatherApp.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherMainPage : ContentPage
    {
<<<<<<< HEAD
        private PollingTimerHelper timer = null;

=======
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
        public WeatherMainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //if (String.IsNullOrEmpty(Preferences.Get("Latitude", "")) && String.IsNullOrEmpty(Preferences.Get("Longitude", "")))
            //{
            //    
            //}
<<<<<<< HEAD
            await GeolocationHelper.GetGeolocationInfo(viewModel.geoModel); 
            await viewModel.LoadActualAndDailyWeatherInfoForSevenDays();

            timer = new PollingTimerHelper(TimeSpan.FromMinutes(1), async () => { await GeolocationHelper.GetGeolocationInfo(viewModel.geoModel); await viewModel.LoadActualAndDailyWeatherInfoForSevenDays(); });
            timer.Start();
=======

            await viewModel.GetGeolocationInfo();
            await viewModel.LoadActualAndDailyWeatherInfoForSevenDays();
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
        }

        private async void WeatherForecastList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
<<<<<<< HEAD
=======
            DailyForecastForSevenDaysModel dailyForecastItem = (DailyForecastForSevenDaysModel)e.Item;

>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
            if (viewModel.IsBusy)
                return;

            viewModel.IsBusy = true;
            try
            {
<<<<<<< HEAD
                DailyForecastForSevenDaysModel dailyForecastItem = (DailyForecastForSevenDaysModel)e.Item;
=======
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
                await PopupNavigation.Instance.PushAsync(new WeatherInfoPopup(dailyForecastItem));
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Błąd", "Coś poszło nie tak.", "OK");
            }
            finally
            {
                viewModel.IsBusy = false;
            }
        }
<<<<<<< HEAD

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            timer.Stop();
        }
=======
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
    }
}
