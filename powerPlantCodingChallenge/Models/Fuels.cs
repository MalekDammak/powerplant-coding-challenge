using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace powerPlantCodingChallenge.Models
{
    public class Fuels
    {
        [JsonPropertyName("gas(euro/MWh)")]
        [Range(0, double.MaxValue, ErrorMessage = "Value must be positive.")]
        public decimal Gas { get; set; }
        [JsonPropertyName("kerosine(euro/MWh)")]
        [Range(0, double.MaxValue, ErrorMessage = "Value must be positive.")]
        public decimal Kerosine { get; set; }
        [JsonPropertyName("co2(euro/ton)")]
        [Range(0, double.MaxValue, ErrorMessage = "Value must be positive.")]
        public decimal Co2 { get; set; }
        [JsonPropertyName("wind(%)")]
        [Range(0, 100, ErrorMessage = "Range should be from 0 to 100")]
        public decimal Wind { get; set; }
    }
}

