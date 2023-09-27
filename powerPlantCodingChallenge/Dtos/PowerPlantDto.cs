using System.ComponentModel.DataAnnotations;

namespace powerPlantCodingChallenge.Dtos
{
    public class PowerPlantDto
    {
        public required string Name { get; set; }
        public required string Type { get; set; }
        [Range(0, 1, ErrorMessage = "Range should be from 0 to 1")]
        public decimal Efficiency { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed.")]
        public int Pmin { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed.")]
        public int Pmax { get; set; }
    }
}

