using MyWeatherApp.Helpers;
using MyWeatherApp.Models;
using MyWeatherApp.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyWeatherApp.ViewModels
{
    public class WeatherMainViewModel : BaseViewModel
    {
        private readonly WeatherInfoModel model = new WeatherInfoModel();
        public ObservableCollection<DailyForecastForSevenDaysModel> DailyForecastList { get; set; } = new ObservableCollection<DailyForecastForSevenDaysModel>();
<<<<<<< HEAD
        public GeolocationModel geoModel { get; set; } = new GeolocationModel();
=======
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f

        public string Location
        {
            get { return model.Name; }
            set { model.Name = value; OnPropertyChanged(); }
        }

        public string DescriptionOfWeather
        {
            get { return model.Weather.Description; }
            set { model.Weather.Description = value; OnPropertyChanged(); }
        }

        public string DateAndTime
        {
            get { return model.Dt; }
            set { model.Dt = value; OnPropertyChanged(); }
        }

        public string Temperature
        {
            get { return model.Main.Temp; }
            set { model.Main.Temp = value; OnPropertyChanged(); }
        }

        public string FeelsLikeTemperature
        {
            get { return model.Main.FeelsLike; }
            set { model.Main.FeelsLike = value; OnPropertyChanged(); }
        }

        public string Humidity
        {
            get { return model.Main.Humidity; }
            set { model.Main.Humidity = value; OnPropertyChanged(); }
        }

        public string WindSpeed
        {
            get { return model.Wind.Speed; }
            set { model.Wind.Speed = value; OnPropertyChanged(); }
        }

        public string WindDirection
        {
            get { return model.Wind.Deg; }
            set { model.Wind.Deg = value; OnPropertyChanged(); }
        }

        public string Pressure
        {
            get { return model.Main.Pressure; }
            set { model.Main.Pressure = value; OnPropertyChanged(); }
        }

        public string Clouds
        {
            get { return model.Clouds.All; }
            set { model.Clouds.All = value; OnPropertyChanged(); }
        }

        public string Icon
        {
            get { return model.Weather.Icon; }
            set { model.Weather.Icon = value; OnPropertyChanged(); }
        }

        public string SunriseTime
        {
            get { return model.Sys.Sunrise; }
            set { model.Sys.Sunrise = value; OnPropertyChanged(); }
        }

        public string SunsetTime
        {
            get { return model.Sys.Sunset; }
            set { model.Sys.Sunset = value; OnPropertyChanged(); }
        }


        public ICommand GoTo48HoursForecast { get; protected set; }

        public WeatherMainViewModel()
        {
            GoTo48HoursForecast = new Command(() => ExecuteGoTo48HoursForecast());
        }

        private async void ExecuteGoTo48HoursForecast()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new ForecastFor48HoursPage());
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Błąd", "Coś poszło nie tak.", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async Task LoadActualAndDailyWeatherInfoForSevenDays()
        {
            if (IsBusy)
                return;

            DailyForecastList.Clear();
            IsBusy = true;
            try
            {
<<<<<<< HEAD
                var result = await HttpConnection.GetActualWeatherInfoForLocationAsync(geoModel.Location, "apiKey");
=======
                var result = await HttpConnection.GetActualWeatherInfoForLocationAsync("Rzeszów", "apiKey");
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
                if (result != null)
                {
                    Location = result.Name;
                    DescriptionOfWeather = result.Weather.First().Description;
                    DateAndTime = DateAndTimeHelper.ConvertToDateAndTime(result.Dt, DateAndTimeHelper.TypeForDateAndTimeFormat.COMMON_DATETIME);
                    SunriseTime = DateAndTimeHelper.ConvertToDateAndTime(result.Sys.Sunrise, DateAndTimeHelper.TypeForDateAndTimeFormat.TIME);
                    SunsetTime = DateAndTimeHelper.ConvertToDateAndTime(result.Sys.Sunset, DateAndTimeHelper.TypeForDateAndTimeFormat.TIME);
                    Temperature = Math.Round(result.Main.Temp.Value, 1).ToString();
                    FeelsLikeTemperature = Math.Round(result.Main.FeelsLike.Value, 1).ToString();
                    Humidity = result.Main.Humidity;
                    WindSpeed = WindHelper.MpsToKmph(result.Wind.Speed.Value);
                    Pressure = result.Main.Pressure;
                    Clouds = result.Clouds.All;
                    WindDirection = WindHelper.DegreesToGeogrpahicalDirections(result.Wind.Deg.Value);
                    Icon = HttpConnection.GetIconForWeather(result.Weather.First().Icon);
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Błąd", "Coś poszło nie tak.", "OK");
                }

<<<<<<< HEAD
                var resultForDailyWeatherInfo = await HttpConnection.GetDailyWeatherInfoForSevenDaysAsync(geoModel.Lat, geoModel.Lon, "apiKey");
=======
                var resultForDailyWeatherInfo = await HttpConnection.GetDailyWeatherInfoForSevenDaysAsync(Preferences.Get("Latitude", ""), Preferences.Get("Longitude", ""), "apiKey");
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f

                if (resultForDailyWeatherInfo.Daily != null)
                {
                    foreach (var item in resultForDailyWeatherInfo.Daily)
                    {
                        DailyForecastList.Add(new DailyForecastForSevenDaysModel
                        {
                            Dt = DateAndTimeHelper.ConvertToDateAndTime(item.Dt, DateAndTimeHelper.TypeForDateAndTimeFormat.COMMON_DATETIME),
                            DayTemp = Math.Round(item.Temp.Day.Value, 1).ToString(),
                            NightTemp = Math.Round(item.Temp.Night.Value, 1).ToString(),
                            MinTemp = Math.Round(item.Temp.Min.Value, 1).ToString(),
                            MaxTemp = Math.Round(item.Temp.Max.Value, 1).ToString(),
                            FeelsTempDay = Math.Round(item.FeelsLike.Day.Value, 1).ToString(),
                            Humidity = item.Humidity,
                            Sunrise = DateAndTimeHelper.ConvertToDateAndTime(item.Sunrise, DateAndTimeHelper.TypeForDateAndTimeFormat.TIME),
                            Sunset = DateAndTimeHelper.ConvertToDateAndTime(item.Sunset, DateAndTimeHelper.TypeForDateAndTimeFormat.TIME),
                            WindDeg = WindHelper.DegreesToGeogrpahicalDirections(item.WindDeg.Value),
                            WindSpeed = WindHelper.MpsToKmph(item.WindSpeed.Value),
                            Rain = string.IsNullOrEmpty(item.Rain) ? "0" : item.Rain,
                            Icon = HttpConnection.GetIconForWeather(item.Weather.First().Icon),
                            Clouds = item.Clouds,
                            Pressure = item.Pressure,
                            Description = item.Weather.First().Description
                        });
                    }
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Błąd", "Coś poszło nie tak.", "OK");
                }
            }

            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Błąd", "Coś poszło nie tak. Być może nie włączono Internetu.", "OK");
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
            finally
            {
                IsBusy = false;
            }
        }
<<<<<<< HEAD
=======

        public async Task GetGeolocationInfo()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                    Preferences.Set("Latitude", location.Latitude.ToString());
                    Preferences.Set("Longitude", location.Longitude.ToString());
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await App.Current.MainPage.DisplayAlert("Błąd", $"Usługa geolokalizacji nie jest dostępna na tym urzędzeniu - {fnsEx}.", "OK");
            }
            catch (PermissionException pEx)
            {
                await App.Current.MainPage.DisplayAlert("Błąd", $"Wystąpił problem z uprawnieniami lokalizacji - {pEx}.", "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Błąd", $"Coś poszło nie tak {ex}", "OK");
            }
        }
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f
    }
}
