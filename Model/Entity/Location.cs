using System.Text.Json.Serialization;

namespace ParkEase.Model.Entity
{
    public class Location
    {
        [JsonPropertyName("code")]
        public required string Code { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("is_exit")]
        public required bool IsExit { get; set; }
    }

    public class LocationFilterRequest
    {
        [JsonPropertyName("is_active")]
        public bool? IsExit{ get; set; }
    }
}