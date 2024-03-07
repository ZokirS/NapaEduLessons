namespace WeatherApp.Models.Entity
{
    public class Location
    {
        public int Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public List<HourlyInfo> Hourly { get; set; }
    }
}
