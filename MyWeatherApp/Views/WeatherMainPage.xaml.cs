using MyWeatherApp.Models;
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

            await viewModel.GetGeolocationInfo();
            await viewModel.LoadActualAndDailyWeatherInfoForSevenDays();
        }

        private async void WeatherForecastList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DailyForecastForSevenDaysModel dailyForecastItem = (DailyForecastForSevenDaysModel)e.Item;

            if (viewModel.IsBusy)
                return;

            viewModel.IsBusy = true;
            try
            {
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
    }
}
