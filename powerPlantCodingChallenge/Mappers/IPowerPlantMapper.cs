using powerPlantCodingChallenge.Dtos;
using powerPlantCodingChallenge.Models;

namespace powerPlantCodingChallenge.Mappers
{
    public interface IPowerPlantMapper
    {
        PowerPlant ToModel(Fuels fuel, PowerPlantDto powerPlantMapperDto);

    }
}
