using System.Text.Json.Serialization;

namespace ParkEase.Model.Entity
{
    public class VehicleType
    {
        [JsonPropertyName("code")]
        public required string Code { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("price")]
        public long Price { get; set; }
    }
}
