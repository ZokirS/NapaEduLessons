using System.Text.Json;
using WeatherApp;
using WeatherApp.Helper;
using WeatherApp.Models;
using WeatherApp.Models.Entity;
using WeatherApp.Services;


var context = new ApplicationDbContext();
var obj = new WeatherRequestModel
{
    Latitude = 41.311081F,
    Longitude = 69.240562F,
    Hourly = ["temperature_2m","rain" ]
};
using var client = new HttpClient();

var response = await client.GetAsync($"https://api.open-meteo.com/v1/forecast?latitude={obj.Latitude}&longitude={obj.Longitude}&hourly={string.Join(",",obj.Hourly)}");
var resString =  await response.Content.ReadAsStringAsync();
var responseModel = JsonSerializer.Deserialize<WeatherResponse>(resString, new JsonSerializerOptions { PropertyNamingPolicy = new SnakeCaseNamingPolicy() });

var locationService = new LocationService();
locationService.AddDataFromApi(responseModel);
Console.WriteLine();
