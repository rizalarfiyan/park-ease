using System.Text.Json.Serialization;

namespace ParkEase.Model.Entity
{
    public class Setting
    {
        [JsonPropertyName("fine_ticket_calculation")]
        public int FineTicketCalculation { get; set; }

        [JsonPropertyName("fine_ticket_calculation_description")]
        public required string FineTicketCalculationDescription { get; set; }

        [JsonPropertyName("next_hour_calculation")]
        public int NextHourCalculation { get; set; }

        [JsonPropertyName("next_hour_calculation_description")]
        public required string NextHourCalculationDescription { get; set; }

        [JsonPropertyName("max_capacity")]
        public int MaxCapacity { get; set; }

        [JsonPropertyName("max_capacity_description")]
        public required string MaxCapacityDescription { get; set; }
    }

    public class SettingRequest
    {
        [JsonPropertyName("fine_ticket_calculation")]
        public int FineTicketCalculation { get; set; }

        [JsonPropertyName("next_hour_calculation")]
        public int NextHourCalculation { get; set; }

        [JsonPropertyName("max_capacity")]
        public int MaxCapacity { get; set; }
    }
}
