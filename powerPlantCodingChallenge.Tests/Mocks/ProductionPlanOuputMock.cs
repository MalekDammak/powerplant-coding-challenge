using powerPlantCodingChallenge.Dtos;
namespace powerPlantCodingCallenge.Tests.Mocks
{
    public static class ProductionPlanOuputMock
    {
        public static List<PowerPlantOutputDto> GetMock()
        {
            return new List<PowerPlantOutputDto>
            {
                new PowerPlantOutputDto()
                {
                    Name = "windpark1",

                    P=90.0m,

                },
                new PowerPlantOutputDto()
                {
                    Name = "windpark2",

                    P=21.6m,

                },
                new PowerPlantOutputDto()
                {
                    Name = "gasfiredbig1",

                    P=460.0m,

                },
                new PowerPlantOutputDto()
                {
                    Name = "gasfiredbig2",

                    P=338.4m,

                },
                new PowerPlantOutputDto()
                {
                    Name = "gasfiredsomewhatsmaller",

                    P=0.0m,

                },
                new PowerPlantOutputDto()
                {
                    Name = "tj1",

                    P=0.0m,

                }

            };

        }
    }
}

