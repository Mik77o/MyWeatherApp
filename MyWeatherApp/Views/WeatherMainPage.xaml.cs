using MyWeatherApp.Helpers;
using MyWeatherApp.Models;
using MyWeatherApp.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherMainPage : ContentPage
    {
        private PollingTimerHelper timer = null;

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

            await GeolocationHelper.GetGeolocationInfo(viewModel.geoModel);
            await viewModel.LoadActualAndDailyWeatherInfoForSevenDays();

            timer = new PollingTimerHelper(TimeSpan.FromMinutes(1), async () => { await GeolocationHelper.GetGeolocationInfo(viewModel.geoModel); await viewModel.LoadActualAndDailyWeatherInfoForSevenDays(); });
            timer.Start();
        }

        private async void WeatherForecastList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (viewModel.IsBusy)
                return;

            viewModel.IsBusy = true;
            try
            {

                DailyForecastForSevenDaysModel dailyForecastItem = (DailyForecastForSevenDaysModel)e.Item;

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

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            timer.Stop();
        }
    }
}
