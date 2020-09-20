using MyWeatherApp.Models;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWeatherApp.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherHourlyPopup : PopupPage
    {
        public WeatherHourlyPopup(Forecast48HoursModel mod)
        {
            InitializeComponent();
            viewModel.Description = mod.Description;
            viewModel.DateAndTime = mod.DateAndTime;
            viewModel.Icon = mod.Icon;
            viewModel.Temp = mod.Temp;
            viewModel.FeelsTemp = mod.FeelsTemp;
            viewModel.Humidity = mod.Humidity;
            viewModel.Pressure = mod.Pressure;
            viewModel.WindDeg = mod.WindDeg;
            viewModel.WindSpeed = mod.WindSpeed;
            viewModel.Rain = mod.Rain;
            viewModel.Clouds = mod.Clouds;
            viewModel.ColorOfTemperatureLabel = mod.ColorOfTemperatureLabel;
        }
    }
}