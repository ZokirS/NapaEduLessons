using System.Globalization;
using System.Text;
using System.Text.Json;
using WebProgramming;
using WebProgramming.Models;

//var uri = "https://jsonplaceholder.typicode.com";

//using (var client = new HttpClient())
//{
//    //var message = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/");
//    var content = new StringContent("{\"title\":\"foo\",\"body\": \"bar\",\"userId\": 1}", Encoding.UTF8, "application/json");
//    var result = client.PostAsync("/posts", content);
//    Console.WriteLine(result.Result.Content.ReadAsStringAsync().Result);
//}

//using (var client = new HttpClient())
//{
//    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
//    var getResult = client.GetAsync("posts");
//    Console.WriteLine(getResult.Result.Content.ReadAsStringAsync().Result);
//}

//using (var client = new HttpClient())
//{
//    var model = new ModelClass
//    {
//        Title = "foo",
//        Body = "bar",
//        UserId = 1
//    };
//    var json = JsonSerializer.Serialize(model);
//    var content = new StringContent(json, Encoding.UTF8, "application/json");
//    var res = client.PostAsync($"{uri}/posts", content).Result;
//    Console.WriteLine(res.Content.ReadAsStringAsync().Result);
//}
var policy = new SnakeCaseNamingPolicy();
using (var client = new HttpClient())
{
    var res = client.GetAsync($"http://api.weatherapi.com/v1/current.json?key=8ee1d8db3dd9400f9df72947240502&q=tashkent").Result;
    var result = res.Content.ReadAsStringAsync().Result;
    var json = JsonSerializer.Deserialize<Rootobject>(result,
        new JsonSerializerOptions { PropertyNamingPolicy = policy});
}


public class Rootobject
{
    public Location Location { get; set; }
    public Current Current { get; set; }
}

public class Location
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public float Lat { get; set; }
    public float Lon { get; set; }
    public string TzId { get; set; }
    public int LocaltimeEpoch { get; set; }
    public string Localtime { get; set; }
}

public class Current
{
    public int LastUpdatedEpoch { get; set; }
    public string LastUpdated { get; set; }
    public float TempC { get; set; }
    public float TempF { get; set; }
    public int IsDay { get; set; }
    public Condition Condition { get; set; }
    public float WindMph { get; set; }
    public float windKph { get; set; }
    public int WindDegree { get; set; }
    public string WindDir { get; set; }
    public float PressureMb { get; set; }
    public float PressureIn { get; set; }
    public float PrecipMm { get; set; }
    public float PrecipIn { get; set; }
    public int Humidity { get; set; }
    public int Cloud { get; set; }
    public float FeelslikeC { get; set; }
    public float FeelslikeF { get; set; }
    public float VisKm { get; set; }
    public float VisMiles { get; set; }
    public float Uv { get; set; }
    public float GustMph { get; set; }
    public float GustKph { get; set; }
}

public class Condition
{
    public string text { get; set; }
    public string icon { get; set; }
    public int code { get; set; }
}
