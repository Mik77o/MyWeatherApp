
namespace MyWeatherApp.Models
{
    public class DailyForecastForSevenDaysModel
    {
        public long Id { get; set; }
        public string Dt { get; set; }
        public string DayTemp { get; set; }
        public string NightTemp { get; set; }
        public string FeelsTempDay { get; set; }
        public string MinTemp { get; set; }
        public string MaxTemp { get; set; }
        public string Pressure { get; set; }
        public string Description { get; set; }
        public string WindSpeed { get; set; }
        public string Humidity{ get; set; }
        public string WindDeg { get; set; }
        public string Icon { get; set; }
        public string Clouds { get; set; }
        public string Rain { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}
