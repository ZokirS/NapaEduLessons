namespace WeatherApp.Models.Entity
{
    public class HourlyInfo
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public float Temperature { get; set; }
        public float Rain { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
