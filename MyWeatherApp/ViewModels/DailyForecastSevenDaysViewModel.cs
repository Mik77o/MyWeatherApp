using MyWeatherApp.Models;
using Rg.Plugins.Popup.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyWeatherApp.ViewModels
{
    public class DailyForecastSevenDaysViewModel : BaseViewModel
    {
        private readonly DailyForecastForSevenDaysModel model = new DailyForecastForSevenDaysModel();

        public string Date
        {
            get => model.Dt;
            set { model.Dt = value; OnPropertyChanged(); }
        }

        public string DayTemp
        {
            get => model.DayTemp;
            set { model.DayTemp = value; OnPropertyChanged(); }
        }

        public string NightTemp
        {
            get => model.NightTemp;
            set { model.NightTemp = value; OnPropertyChanged(); }
        }

        public string FeelsTempDay
        {
            get => model.FeelsTempDay;
            set { model.FeelsTempDay = value; OnPropertyChanged(); }
        }

        public string MinTemp
        {
            get => model.MinTemp;
            set { model.MinTemp = value; OnPropertyChanged(); }
        }

        public string MaxTemp
        {
            get => model.MaxTemp;
            set { model.MaxTemp = value; OnPropertyChanged(); }
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
        public string Sunrise
        {
            get => model.Sunrise;
            set { model.Sunrise = value; OnPropertyChanged(); }
        }

        public string Sunset
        {
            get => model.Sunset;
            set { model.Sunset = value; OnPropertyChanged(); }
        }

        public ICommand ExitPopupCommand { get; protected set; }

        public DailyForecastSevenDaysViewModel()
        {
            ExitPopupCommand = new Command(() => ExecuteExitPopupCommand());
        }

        private async void ExecuteExitPopupCommand()
        {
            await PopupNavigation.Instance.PopAsync();
        }

    }
}
