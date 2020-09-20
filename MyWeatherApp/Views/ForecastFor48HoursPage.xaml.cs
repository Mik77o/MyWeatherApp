using MyWeatherApp.Models;
using MyWeatherApp.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForecastFor48HoursPage : ContentPage
    {
        public ForecastFor48HoursPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Load48HoursWeatherInfo();
        }

        private async void WeatherHourInfoList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Forecast48HoursModel hourlyWeatherItem = (Forecast48HoursModel)e.Item;

            if (viewModel.IsBusy)
                return;

            viewModel.IsBusy = true;
            try
            {
                await PopupNavigation.Instance.PushAsync(new WeatherHourlyPopup(hourlyWeatherItem));
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