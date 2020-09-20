
namespace MyWeatherApp.Models
{
    public class WeatherInfoModel
    {
        public WeatherModel Weather { get; set; } = new WeatherModel();
        public MainModel Main { get; set; } = new MainModel();
        public int Visibility { get; set; }
        public WindModel Wind { get; set; } = new WindModel();
        public RainModel Rain { get; set; } = new RainModel();
        public CloudsModel Clouds { get; set; } = new CloudsModel();
        public string Dt { get; set; }
        public SysModel Sys { get; set; } = new SysModel();
        public long Id { get; set; }
        public string Name { get; set; }
    }
}



