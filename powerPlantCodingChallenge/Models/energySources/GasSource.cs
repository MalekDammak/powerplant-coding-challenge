namespace powerPlantCodingChallenge.Models
{
    public class GasSource : EnergySource
    {
        public GasSource()
        {

        }
        public GasSource(decimal price, decimal efficiency, decimal co2Price, decimal pMax)
        {
            Price = (price / efficiency) + (co2Price * 0.3m);
            MaxPower = pMax;
        }

    }
}

