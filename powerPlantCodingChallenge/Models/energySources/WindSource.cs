namespace powerPlantCodingChallenge.Models
{
    public class WindSource : EnergySource
    {
        public WindSource()
        {

        }
        public WindSource(decimal price, decimal wind, decimal pMax)
        {
            Price = price;
            MaxPower = wind / 100 * pMax;
        }
    }
}

