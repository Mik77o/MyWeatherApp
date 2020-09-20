
namespace MyWeatherApp.Models
{
    public class Forecast48HoursModel
    {
        public string Dt { get; set; }

        public string DateAndTime { get; set; }
        public string Temp { get; set; }
        public string WindDeg { get; set; }
        public long Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string GroupName { get; set; }
        public string ColorOfTemperatureLabel { get; set; } = "#008000";
        public string FeelsTemp { get; set; }
        public string Pressure { get; set; }
        public string WindSpeed { get; set; }
        public string Humidity { get; set; }
        public string Clouds { get; set; }
        public string Rain { get; set; }
    }
}