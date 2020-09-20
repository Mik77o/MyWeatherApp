using MyWeatherApp.Models;
using Rg.Plugins.Popup.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyWeatherApp.ViewModels
{
    public class HourlyWeatherViewModel: BaseViewModel
    {
        private readonly Forecast48HoursModel model = new Forecast48HoursModel();

        public string DateAndTime
        {
            get => model.DateAndTime;
            set { model.DateAndTime = value; OnPropertyChanged(); }
        }

        public string Temp
        {
            get => model.Temp;
            set { model.Temp = value; OnPropertyChanged(); }
        }

        public string FeelsTemp
        {
            get => model.FeelsTemp;
            set { model.FeelsTemp = value; OnPropertyChanged(); }
        }

        public string Pressure
        {
            get => model.Pressure;
            set { model.Pressure = value; OnPropertyChanged(); }
        }


        public string Humidity
        {
            get => model.Humidity;
            set { model.Humidity = value; OnPropertyChanged(); }
        }

        public string Description
        {
            get => model.Description;
            set { model.Description = value; OnPropertyChanged(); }
        }

        public string WindSpeed
        {
            get => model.WindSpeed;
            set { model.WindSpeed = value; OnPropertyChanged(); }
        }

        public string WindDeg
        {
            get => model.WindDeg;
            set { model.WindDeg = value; OnPropertyChanged(); }
        }

        public string Icon
        {
            get => model.Icon;
            set { model.Icon = value; OnPropertyChanged(); }
        }

        public string Clouds
        {
            get => model.Clouds;
            set { model.Clouds = value; OnPropertyChanged(); }
        }

        public string Rain
        {
            get => model.Rain;
            set { model.Rain = value; OnPropertyChanged(); }
        }

        public string ColorOfTemperatureLabel
        {
            get => model.ColorOfTemperatureLabel;
            set { model.ColorOfTemperatureLabel = value; OnPropertyChanged(); }
        }

        public ICommand ExitPopupCommand { get; protected set; }

        public HourlyWeatherViewModel()
        {
            ExitPopupCommand = new Command(() => ExecuteExitPopupCommand());
        }

        private async void ExecuteExitPopupCommand()
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}
