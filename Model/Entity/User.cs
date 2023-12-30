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

    public class UserRequest: User
    {
        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }

    public class AuthLogin
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

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

    public class ChangePasswordRequest
    {
        [JsonPropertyName("old_password")]
        public required string OldPassword { get; set; }

        [JsonPropertyName("password")]
        public required string Password { get; set; }

        [JsonPropertyName("password_confirmation")]
        public required string PasswordConfirmation { get; set; }
    }
}
