using powerPlantCodingChallenge.Dtos;
using powerPlantCodingChallenge.Models;

namespace PowerPlantCodingChallenge.Tests.Mocks
{
    public static class ProductionPlanDtoMock
    {
        public static ProductionPlanDto GetMock(decimal load)
        {
            return new ProductionPlanDto()
            {
                Load = load,
                Fuels = new Fuels
                {
                    Gas = 13.4m,
                    Co2 = 20,
                    Kerosine = 50.8m,
                    Wind = 60

                },
                PowerPlants = new List<PowerPlantDto>{
                    new PowerPlantDto()
                    {
                         Name= "gasfiredbig1",
                         Type= "gasfired",
                         Efficiency= 0.53m,
                         Pmin= 100,
                         Pmax= 460
                    },
                    new PowerPlantDto()
                    {
                         Name= "gasfiredbig2",
                         Type= "gasfired",
                         Efficiency= 0.53m,
                         Pmin= 100,
                         Pmax= 460
                    },
                     new PowerPlantDto()
                    {
                         Name= "gasfiredsomewhatsmaller",
                         Type= "gasfired",
                         Efficiency= 0.37m,
                         Pmin= 40,
                         Pmax= 210
                    },
                     new PowerPlantDto()
                    {
                         Name= "tj1",
                         Type= "turbojet",
                         Efficiency= 0.3m,
                         Pmin= 0,
                         Pmax= 16
                    },
                     new PowerPlantDto()
                    {
                         Name= "windpark1",
                         Type= "windturbine",
                         Efficiency= 1,
                         Pmin= 0,
                         Pmax= 150
                    },
                     new PowerPlantDto()
                    {
                         Name= "windpark2",
                         Type= "windturbine",
                         Efficiency= 1,
                         Pmin= 0,
                         Pmax= 36
                    }
                }


            };
        }

    }
}

