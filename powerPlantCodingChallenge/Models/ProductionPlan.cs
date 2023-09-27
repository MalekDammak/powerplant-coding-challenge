namespace powerPlantCodingChallenge.Models
{
    public class ProductionPlan
    {
        public required decimal Load { get; set; }
        public required Fuels Fuels { get; set; }
        public List<PowerPlant> PowerPlants { get; set; }
    }
}
