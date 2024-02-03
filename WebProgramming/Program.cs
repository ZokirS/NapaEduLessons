using System.Text;
using System.Text.Json;
using WebProgramming;
using WebProgramming.Models;

var uri = "https://jsonplaceholder.typicode.com";

using (var client = new HttpClient())
{
    //var message = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/");
    var content = new StringContent("{\"title\":\"foo\",\"body\": \"bar\",\"userId\": 1}", Encoding.UTF8, "application/json");
    var result = client.PostAsync("/posts", content);
    Console.WriteLine(result.Result.Content.ReadAsStringAsync().Result);  
}

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
    var getResult = client.GetAsync("posts");
    Console.WriteLine(getResult.Result.Content.ReadAsStringAsync().Result);
}

using(var client = new HttpClient())
{
    var model = new ModelClass
    {
        Title = "foo",
        Body = "bar",
        UserId = 1
    };
    var json = JsonSerializer.Serialize(model);
    var content = new StringContent(json, Encoding.UTF8, "application/json");
    var res = client.PostAsync($"{uri}/posts", content).Result;
    Console.WriteLine(res.Content.ReadAsStringAsync().Result);
}

Console.WriteLine("Please enter user id: ");
var userId = int.Parse(Console.ReadLine());
using (var client = new HttpClient())
{
    client.BaseAddress = new Uri(uri);
    var res = client.GetAsync($"/posts?userId={userId}").Result;
    
    var result = res.Content.ReadAsStringAsync().Result;
    var json = JsonSerializer.Deserialize<List<ModelClass>>(result,
        new JsonSerializerOptions {PropertyNameCaseInsensitive = true });
}