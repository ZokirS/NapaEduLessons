namespace WeatherApp.Models
{
    internal class WeatherResponse
    {
            public float Latitude { get; set; }
            public float Longitude { get; set; }
            public float GenerationtimeMs { get; set; }
            public int UtcOffsetSeconds { get; set; }
            public string Timezone { get; set; }
            public string TimezoneAbbreviation { get; set; }
            public float Elevation { get; set; }
            public Hourly_Units HourlyUnits { get; set; }
            public Hourly Hourly { get; set; }
        }

        public class Hourly_Units
        {
            public string Time { get; set; }
            public string Temperature2m { get; set; }
            public string Rain { get; set; }
        }

        public class Hourly
        {
            public string[] Time { get; set; }
            public float[] Temperature2m { get; set; }
            public float[] Rain { get; set; }
        }

    }
