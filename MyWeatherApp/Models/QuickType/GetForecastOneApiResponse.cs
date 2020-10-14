using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyWeatherApp.Models.QuickType
{
    public partial class GetForecastOneApiResponse
    {
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public string Lat { get; set; }

        [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
        public string Lon { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimezoneOffset { get; set; }

        [JsonProperty("hourly", NullValueHandling = NullValueHandling.Ignore)]
        public List<Hourly48Forecast> Hourly { get; set; }

        [JsonProperty("daily", NullValueHandling = NullValueHandling.Ignore)]
        public List<DailyForSevenDaysForecast> Daily { get; set; }
    }

    public partial class DailyForSevenDaysForecast
    {
        [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
        public string Dt { get; set; }

        [JsonProperty("sunrise", NullValueHandling = NullValueHandling.Ignore)]
        public string Sunrise { get; set; }

        [JsonProperty("sunset", NullValueHandling = NullValueHandling.Ignore)]
        public string Sunset { get; set; }

        [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
        public Temp Temp { get; set; }

        [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
        public FeelsLikeTemperature FeelsLike { get; set; }

        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public string Pressure { get; set; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public string Humidity { get; set; }

        [JsonProperty("dew_point", NullValueHandling = NullValueHandling.Ignore)]
        public string DewPoint { get; set; }

        [JsonProperty("wind_speed", NullValueHandling = NullValueHandling.Ignore)]
        public double? WindSpeed { get; set; }

        [JsonProperty("wind_deg", NullValueHandling = NullValueHandling.Ignore)]
        public double? WindDeg { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public List<Weather> Weather { get; set; }

        [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
        public string Clouds { get; set; }

        [JsonProperty("pop", NullValueHandling = NullValueHandling.Ignore)]
        public string Pop { get; set; }

        [JsonProperty("uvi", NullValueHandling = NullValueHandling.Ignore)]
        public string Uvi { get; set; }

        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        public string Rain { get; set; }
    }

    public partial class FeelsLikeTemperature
    {
        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Day { get; set; }

        [JsonProperty("night", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Night { get; set; }

        [JsonProperty("eve", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Eve { get; set; }

        [JsonProperty("morn", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Morn { get; set; }
    }

    public partial class Temp
    {
        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Day { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Min { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Max { get; set; }

        [JsonProperty("night", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Night { get; set; }

        [JsonProperty("eve", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Eve { get; set; }

        [JsonProperty("morn", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Morn { get; set; }
    }

    public partial class Hourly48Forecast
    {
        [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
        public string Dt { get; set; }

        [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Temp { get; set; }

        [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FeelsLike { get; set; }

        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public string Pressure { get; set; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public string Humidity { get; set; }

        [JsonProperty("dew_point", NullValueHandling = NullValueHandling.Ignore)]
        public string DewPoint { get; set; }

        [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
        public string Clouds { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        [JsonProperty("wind_speed", NullValueHandling = NullValueHandling.Ignore)]
        public double? WindSpeed { get; set; }

        [JsonProperty("wind_deg", NullValueHandling = NullValueHandling.Ignore)]
        public double? WindDeg { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public List<Weather> Weather { get; set; }

        [JsonProperty("1h", NullValueHandling = NullValueHandling.Ignore)]
        public string Rain { get; set; }

        [JsonProperty("pop", NullValueHandling = NullValueHandling.Ignore)]
        public string Pop { get; set; }
    }

    public partial class GetForecastOneApiResponse
    {
        public static GetForecastOneApiResponse FromJson(string json) => JsonConvert.DeserializeObject<GetForecastOneApiResponse>(json, QuickType.Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this GetForecastOneApiResponse self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }
}
