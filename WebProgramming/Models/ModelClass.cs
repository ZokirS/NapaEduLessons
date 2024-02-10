using System.Text.Json.Serialization;

namespace WebProgramming.Models
{
    public class ModelClass
    {
        public string Title { get; set; }
        public string Body { get; set; }
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }
        public int Id { get; set; }
    }
}
