using MyWeatherApp.Models.QuickType;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyWeatherApp.Helpers
{
    public class HttpConnection : HttpClient
    {
        public string BaseApiUrl { get; protected set; } = "https://api.openweathermap.org/data/2.5";

        public HttpConnection()
        {

        }

        public async Task<GetActualWeatherForLocationResponse> GetActualWeatherInfoForLocationAsync(string location, string apiKey)
        {
            string requestUri = BaseApiUrl + $"/weather?q={location}&appid={apiKey}&units=metric&lang=pl";
            var response = await GetAsync(requestUri);
            var resultContent = await response.Content.ReadAsStringAsync();
            return GetActualWeatherForLocationResponse.FromJson(resultContent);
        }

        public async Task<GetForecastOneApiResponse> GetDailyWeatherInfoForSevenDaysAsync(string lat, string lon, string apiKey)
        {
            string requestUri = BaseApiUrl + $"/onecall?lat={lat}&lon={lon}&units=metric&exclude=current,hourly,minutely&appid={apiKey}&lang=pl";
            var response = await GetAsync(requestUri);
            var resultContent = await response.Content.ReadAsStringAsync();
            return GetForecastOneApiResponse.FromJson(resultContent);
        }

        public async Task<GetForecastOneApiResponse> Get48HoursWeatherInfoAsync(string lat, string lon, string apiKey)
        {
            string requestUri = BaseApiUrl + $"/onecall?lat={lat}&lon={lon}&units=metric&exclude=current,daily,minutely&appid={apiKey}&lang=pl";
            var response = await GetAsync(requestUri);
            var resultContent = await response.Content.ReadAsStringAsync();
            return GetForecastOneApiResponse.FromJson(resultContent);
        }

        //public async Task<GetActualWeatherForLocationResponse> GetActualWeatherInfoForLocationAsync(string lat, string lon, string apiKey)
        //{
        //    string requestUri = BaseApiUrl + $"/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric&lang=pl";
        //    var response = await GetAsync(requestUri);
        //    var resultContent = await response.Content.ReadAsStringAsync();
        //    return GetActualWeatherForLocationResponse.FromJson(resultContent);
        //}

        public string GetIconForWeather(string iconCode)
        {
            return $"https://openweathermap.org/img/wn/{iconCode}@2x.png";
        }
    }

}
