using System.Text.Json.Serialization;

namespace ParkEase.Model.Entity
{
    public class History
    {
        [JsonPropertyName("date")]
        public required string Date { get; set; }

        [JsonPropertyName("id")]
        public required string Id { get; set; }

        [JsonPropertyName("location_code")]
        public required string LocationCode { get; set; }

        [JsonPropertyName("type")]
        public required string Type { get; set; }

        [JsonPropertyName("vehicle_number")]
        public required string VehicleNumber { get; set; }

        [JsonPropertyName("vehicle_type_code")]
        public required string VehicleTypeCode { get; set; }
    }

    public class EntryHistoryRequest
    {
        [JsonPropertyName("location_code")]
        public required string LocationCode { get; set; }

        [JsonPropertyName("vehicle_number")]
        public required string VehicleNumber { get; set; }

        [JsonPropertyName("vehicle_type_code")]
        public required string VehicleTypeCode { get; set; }
    }

    public class ExitHistoryRequest
    {
        [JsonPropertyName("entry_history_id")]
        public required string EntryHistoryId { get; set; }

        [JsonPropertyName("location_code")]
        public required string LocationCode { get; set; }

        [JsonPropertyName("price")]
        public long Price { get; set; }
    }

    public class FineHistoryRequest
    {
        [JsonPropertyName("address")]
        public required string Address { get; set; }

        [JsonPropertyName("description")]
        public required string Description { get; set; }

        [JsonPropertyName("entry_history_id")]
        public required string EntryHistoryId { get; set; }

        [JsonPropertyName("identity")]
        public required string Identity { get; set; }

        [JsonPropertyName("location_code")]
        public required string LocationCode { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("price")]
        public long Price { get; set; }

        [JsonPropertyName("vehicle_identity")]
        public required string VehicleIdentity { get; set; }
    }
    public class CalculateHistoryRequest
    {
        [JsonPropertyName("entry_history_id")]
        public required string EntryHistoryId { get; set; }

        [JsonPropertyName("is_fine")]
        public bool IsFine { get; set; }
    }

    public partial class HistoryStatistic
    {
        [JsonPropertyName("available_space")]
        public int AvailableSpace { get; set; }

        [JsonPropertyName("charts")]
        public HistoryStatisticChart[] Charts { get; set; }

        [JsonPropertyName("current_vehicle")]
        public int CurrentVehicle { get; set; }

        [JsonPropertyName("exit_revenue")]
        public int ExitRevenue { get; set; }

        [JsonPropertyName("exit_total")]
        public int ExitTotal { get; set; }

        [JsonPropertyName("fine_revenue")]
        public int FineRevenue { get; set; }

        [JsonPropertyName("fine_total")]
        public int FineTotal { get; set; }

        [JsonPropertyName("revenue_total")]
        public int RevenueTotal { get; set; }

        [JsonPropertyName("vehicle_total")]
        public int VehicleTotal { get; set; }
    }

    public partial class HistoryStatisticChart
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("revenue")]
        public long Revenue { get; set; }

        [JsonPropertyName("vehicle")]
        public long Vehicle { get; set; }
    }
}
