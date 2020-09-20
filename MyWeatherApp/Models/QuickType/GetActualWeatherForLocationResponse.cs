using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyWeatherApp.Models.QuickType
{
    public partial class GetActualWeatherForLocationResponse
    {
        [JsonProperty("coord", NullValueHandling = NullValueHandling.Ignore)]
        public Coord Coord { get; set; }

        [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
        public List<Weather> Weather { get; set; }

        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public string Base { get; set; }

        [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
        public Main Main { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public int Visibility { get; set; }

        [JsonProperty("wind", NullValueHandling = NullValueHandling.Ignore)]
        public Wind Wind { get; set; }

        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        public Rain Rain { get; set; }

        [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
        public Clouds Clouds { get; set; }

        [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
        public string Dt { get; set; }

        [JsonProperty("sys", NullValueHandling = NullValueHandling.Ignore)]
        public Sys Sys { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timezone { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("cod", NullValueHandling = NullValueHandling.Ignore)]
        public string Cod { get; set; }
    }

    public partial class Clouds
    {
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public string All { get; set; }
    }

    public partial class Coord
    {
        [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
        public string Lon { get; set; }

        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public string Lat { get; set; }
    }

    public partial class Main
    {
        [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Temp { get; set; }

        [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FeelsLike { get; set; }

        [JsonProperty("temp_min", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TempMin { get; set; }

        [JsonProperty("temp_max", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TempMax { get; set; }

        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public string Pressure { get; set; }

        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public string Humidity { get; set; }
    }

    public partial class Rain
    {
        [JsonProperty("1h", NullValueHandling = NullValueHandling.Ignore)]
        public string The1H { get; set; }
    }

    public partial class Sys
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("sunrise", NullValueHandling = NullValueHandling.Ignore)]
        public string Sunrise { get; set; }

        [JsonProperty("sunset", NullValueHandling = NullValueHandling.Ignore)]

        public string Sunset { get; set; }
    }

    public partial class Weather
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
        public string Main { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }
    }

    public partial class Wind
    {
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public double? Speed { get; set; }

        [JsonProperty("deg", NullValueHandling = NullValueHandling.Ignore)]
        public double? Deg { get; set; }
    }

    public partial class GetActualWeatherForLocationResponse
    {
        public static GetActualWeatherForLocationResponse FromJson(string json) => JsonConvert.DeserializeObject<GetActualWeatherForLocationResponse>(json, QuickType.Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this GetActualWeatherForLocationResponse self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }
}

