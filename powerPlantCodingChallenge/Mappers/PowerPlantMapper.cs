using powerPlantCodingChallenge.Constant;
using powerPlantCodingChallenge.Dtos;
using powerPlantCodingChallenge.Exceptions;
using powerPlantCodingChallenge.Models;

namespace powerPlantCodingChallenge.Mappers
{
    public class PowerPlantMapper : IPowerPlantMapper
    {
        public PowerPlant ToModel(Fuels fuel, PowerPlantDto powerPlantMapperDto)
        {
            return new PowerPlant
            {
                Name = powerPlantMapperDto.Name,
                Pmax = powerPlantMapperDto.Pmax,
                Pmin = powerPlantMapperDto.Pmin,
                Efficiency = powerPlantMapperDto.Efficiency,
                EnergySource = FactoryEnergySource(fuel, powerPlantMapperDto)
            };
        }
        private static EnergySource FactoryEnergySource(Fuels fuel, PowerPlantDto powerPlantMapperDto)
        {
            if (Enum.TryParse(powerPlantMapperDto.Type, out PowerPlantType powerPlantType))
            {
                return powerPlantType switch
                {
                    PowerPlantType.gasfired => new GasSource(fuel.Gas, powerPlantMapperDto.Efficiency, fuel.Co2, powerPlantMapperDto.Pmax),
                    PowerPlantType.turbojet => new KerosineSource(fuel.Kerosine, powerPlantMapperDto.Efficiency, powerPlantMapperDto.Pmax),
                    PowerPlantType.windturbine => new WindSource(0, fuel.Wind, powerPlantMapperDto.Pmax),
                    _ => throw new ValidationException(MessageConstants.PowerPlantTypeNotSupported),
                };
            }
            else
            {
                throw new ValidationException(MessageConstants.InvalidInputPowerPlantType);
            }

        }

    }
}

