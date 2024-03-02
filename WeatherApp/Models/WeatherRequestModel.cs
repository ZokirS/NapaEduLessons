using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class WeatherRequestModel
    {
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        [JsonPropertyName("longitude")]
        public float Longitude { get; set; }
        [JsonPropertyName("hourly")]
        public string[] Hourly { get; set; }

    }

}
