namespace powerPlantCodingChallenge.Models
{
    public class KerosineSource : EnergySource
    {
        public KerosineSource()
        {

        }
        public KerosineSource(decimal price, decimal efficiency, decimal pMax)
        {
            Price = price / efficiency;
            MaxPower = pMax;
        }
    }
}

