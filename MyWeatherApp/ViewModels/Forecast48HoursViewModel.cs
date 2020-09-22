using MyWeatherApp.Helpers;
using MyWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using Xamarin.Essentials;
using Xamarin.Forms;
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f

namespace MyWeatherApp.ViewModels
{
    public class Forecast48HoursViewModel : BaseViewModel
    {
        public List<Forecast48HoursModel> Hourly48ForecastList { get; set; } = new List<Forecast48HoursModel>();
        public ObservableCollection<GroupingForListClass<string, Forecast48HoursModel>> GroupedHourly48ForecastList { get; set; } = new ObservableCollection<GroupingForListClass<string, Forecast48HoursModel>>();
<<<<<<< HEAD
        private GeolocationModel geoModel { get; set; } = new GeolocationModel();
=======
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f

        public class GroupingForListClass<K, T> : ObservableCollection<T>
        {
            public K GroupKey { get; private set; }

            public GroupingForListClass(K key, IEnumerable<T> items)
            {
                GroupKey = key;
                foreach (var item in items)
                    this.Items.Add(item);
            }
        }

        public async Task Load48HoursWeatherInfo()
        {
            if (IsBusy)
                return;

            IsBusy = true;
<<<<<<< HEAD

            try
            {
                await GeolocationHelper.GetGeolocationInfo(geoModel);
                var result = await HttpConnection.Get48HoursWeatherInfoAsync(geoModel.Lat, geoModel.Lon, "apiKey");
=======
            try
            {
                var i = Preferences.Get("Latitude", "");

                var result = await HttpConnection.Get48HoursWeatherInfoAsync(Preferences.Get("Latitude", ""), Preferences.Get("Longitude", ""), "apiKey");
>>>>>>> be34081bceddfe67b1c60177104fac1ef053ee9f

                if (result.Hourly != null)
                {
                    foreach (var item in result.Hourly)
                    {
                        Hourly48ForecastList.Add(new Forecast48HoursModel
                        {
                            Dt = DateAndTimeHelper.ConvertToDateAndTime(item.Dt, DateAndTimeHelper.TypeForDateAndTimeFormat.TIME),
                            DateAndTime = DateAndTimeHelper.ConvertToDateAndTime(item.Dt, DateAndTimeHelper.TypeForDateAndTimeFormat.DATE_AND_TIME_FOR_48FORECAST),
                            Temp = Math.Round(item.Temp.Value, 1).ToString(),
                            Icon = HttpConnection.GetIconForWeather(item.Weather.First().Icon),
                            WindDeg = WindHelper.DegreesToGeogrpahicalDirections(item.WindDeg.Value),
                            GroupName = DateAndTimeHelper.ConvertToDateAndTime(item.Dt, DateAndTimeHelper.TypeForDateAndTimeFormat.COMMON_DATETIME),
                            ColorOfTemperatureLabel = item.Weather.First().Icon.Contains("n")?"#000000": "#008000",
                            Humidity = item.Humidity,
                            WindSpeed = WindHelper.MpsToKmph(item.WindSpeed.Value),
                            Rain = string.IsNullOrEmpty(item.Rain) ? "0" : item.Rain,
                            Clouds = item.Clouds,
                            Pressure = item.Pressure,
                            Description = item.Weather.First().Description,
                            FeelsTemp = Math.Round(item.FeelsLike.Value, 1).ToString()
                        });
                    }

                    List<string> groupNamesList = new List<string>();

                    foreach (var item in Hourly48ForecastList)
                    {
                        groupNamesList.Add(item.GroupName);
                    }

                    var distinctGroupNamesList = groupNamesList.Distinct().ToList();

                    foreach (var item in distinctGroupNamesList)
                    {
                        GroupedHourly48ForecastList.Add(new GroupingForListClass<string, Forecast48HoursModel>(item, Hourly48ForecastList.Where(x => x.GroupName == item)));
                    }
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Błąd", "Coś poszło nie tak.", "OK");
                }
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

    }
}
