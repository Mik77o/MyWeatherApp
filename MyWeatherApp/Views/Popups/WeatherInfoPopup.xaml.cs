using MyWeatherApp.Models;
using Rg.Plugins.Popup.Pages;
using System.Diagnostics;
using Xamarin.Forms.Xaml;

namespace MyWeatherApp.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherInfoPopup : PopupPage
    {
        public WeatherInfoPopup(DailyForecastForSevenDaysModel mod)
        {
            InitializeComponent();
            viewModel.Description = mod.Description;
            viewModel.Date = mod.Dt;
            viewModel.Icon = mod.Icon;
            viewModel.DayTemp = mod.DayTemp;
            viewModel.NightTemp= mod.NightTemp;
            viewModel.FeelsTempDay = mod.FeelsTempDay;
            viewModel.MinTemp = mod.MinTemp;
            viewModel.MaxTemp = mod.MaxTemp;
            viewModel.Humidity = mod.Humidity;
            viewModel.Pressure = mod.Pressure;
            viewModel.WindDeg = mod.WindDeg;
            viewModel.WindSpeed = mod.WindSpeed;
            viewModel.Rain = mod.Rain;
            viewModel.Sunrise = mod.Sunrise;
            viewModel.Sunset = mod.Sunset;
            viewModel.Clouds = mod.Clouds;
        }
    }
}