using System.Text.Json.Serialization;

namespace ParkEase.Model.Entity
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("role")]
        public required string Role { get; set; }

        [JsonPropertyName("status")]
        public required string Status { get; set; }

        [JsonPropertyName("username")]
        public required string Username { get; set; }
    }
}
