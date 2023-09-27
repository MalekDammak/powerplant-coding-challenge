namespace powerPlantCodingChallenge.Models
{
    public class PowerPlant
    {
        public string Name { get; set; }
        public EnergySource EnergySource { get; set; }
        public decimal Efficiency { get; set; }
        public int Pmin { get; set; }
        public int Pmax { get; set; }
    }
}

