using powerPlantCodingChallenge.Models;

namespace PowerPlantCodingChallenge.Tests.Mocks
{
    public static class ProductionPlanMock
    {
        public static ProductionPlan GetMock(decimal load)
        {
            return new ProductionPlan()
            {
                Load = load,
                Fuels = new Fuels
                {
                    Gas = 13.4m,
                    Co2 = 20,
                    Kerosine = 50.8m,
                    Wind = 60
                },
                PowerPlants = new List<PowerPlant> {
                    new PowerPlant()
                    {
                        Name = "gasfiredbig1",
                        EnergySource = new GasSource()
                        {
                            Price = (13.4m / 0.53m) + (20 * 0.3m),
                            MaxPower = 460
                        },
                        Efficiency = 0.53m,
                        Pmin = 100,
                        Pmax = 460
                    },
                    new PowerPlant()
                    {
                        Name = "gasfiredbig2",
                        EnergySource = new GasSource() {
                            Price = (13.4m / 0.53m) + (20 * 0.3m),
                            MaxPower = 460
                        },
                        Efficiency = 0.53m,
                        Pmin = 100,
                        Pmax = 460
                    },
                    new PowerPlant()
                    {
                        Name = "gasfiredsomewhatsmaller",
                        EnergySource = new GasSource() {
                            Price = (13.4m / 0.37m) + (20 * 0.3m),
                            MaxPower = 210
                        },
                        Efficiency = 0.37m,
                        Pmin = 40,
                        Pmax = 210
                    },
                    new PowerPlant()
                    {
                        Name = "tj1",
                        EnergySource = new KerosineSource() {
                        Price = (50.8m / 0.3m),
                        MaxPower = 210
                    },
                        Efficiency = 0.3m,
                        Pmin = 0,
                        Pmax = 16
                    },
                    new PowerPlant()
                    {
                        Name = "windpark1",
                        EnergySource = new WindSource() {
                            Price = 0,
                            MaxPower = (60m / 100m) *  150m
                        },
                        Efficiency = 1,
                        Pmin = 0,
                        Pmax = 150
                    },
                    new PowerPlant()
                    {
                        Name = "windpark2",
                        EnergySource = new WindSource() {
                            Price = 0,
                            MaxPower = (60m / 100m) *  36m
                        },
                        Efficiency = 1,
                        Pmin = 0,
                        Pmax = 36
                    }


                }
            };
        }

    }
}

