using MyWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MyWeatherApp.Helpers
{
    public static class GeolocationHelper
    {
        public static async Task GetGeolocationInfo(GeolocationModel mod)
        {
            try
            {
                var geoLocation = await Geolocation.GetLastKnownLocationAsync();

                if (geoLocation != null)
                {
                    mod.Lat = geoLocation.Latitude.ToString();
                    mod.Lon = geoLocation.Longitude.ToString();
                    //Preferences.Set("Latitude", geoLocation.Latitude.ToString());
                    //Preferences.Set("Longitude", geoLocation.Longitude.ToString());
                }

                var geoLocations = await Geocoding.GetPlacemarksAsync(geoLocation);
                var geoPlacemark = geoLocations.FirstOrDefault();
                mod.Location = geoPlacemark.Locality;
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
    }
}
