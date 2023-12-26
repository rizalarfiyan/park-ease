using System.Text.Json.Serialization;

namespace ParkEase.Model.Entity
{
    public class User
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("role")]
        public required string Role { get; set; }

        [JsonPropertyName("status")]
        public required string Status { get; set; }

        [JsonPropertyName("username")]
        public required string Username { get; set; }
    }

    public class AuthLogin
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("username")]
        public required string Username { get; set; }

        [JsonPropertyName("role")]
        public required string Role { get; set; }

        [JsonPropertyName("status")]
        public required string Status { get; set; }

        [JsonPropertyName("token")]
        public required string Token { get; set; }

        [JsonPropertyName("expired_at")]
        public DateTimeOffset ExpiredAt { get; set; }
    }
}
