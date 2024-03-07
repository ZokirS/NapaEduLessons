using WeatherApp.Models;
using WeatherApp.Models.Entity;

namespace WeatherApp.Services
{
    public class LocationService
    {
        public void AddDataFromApi(WeatherResponse model)
        {
           var context = new ApplicationDbContext();
            var hourly = new List<HourlyInfo>();

            for (int i = 0; i < model.Hourly.Rain.Length; i++)
            {
                hourly.Add(new HourlyInfo
                {
                    Time = model.Hourly.Time[i],
                    Temperature = model.Hourly.Temperature2m[i],
                    Rain = model.Hourly.Rain[i]
                });
            }
            var location = new Location
            {
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Hourly = hourly
            };
            context.Location.Add(location);
            context.SaveChanges();
        }
    }
}
