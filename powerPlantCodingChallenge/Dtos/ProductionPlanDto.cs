using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using powerPlantCodingChallenge.Models;

namespace powerPlantCodingChallenge.Dtos
{
    public class ProductionPlanDto
    {
        [JsonPropertyName("load")]
        [Range(0, double.MaxValue, ErrorMessage = "Value must be positive.")]
        public decimal Load { get; set; }
        [JsonPropertyName("fuels")]
        public required Fuels Fuels { get; set; }
        [JsonPropertyName("powerPlants")]
        public required List<PowerPlantDto> PowerPlants { get; set; }
    }
}