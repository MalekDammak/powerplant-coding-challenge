using powerPlantCodingChallenge.Dtos;
using powerPlantCodingChallenge.Models;

namespace powerPlantCodingChallenge.Mappers
{
    public class ProductionPlanMapper : IProductionPlanMapper
    {
        private readonly IPowerPlantMapper _powerPlantMapper;

        public ProductionPlanMapper(IPowerPlantMapper powerPlantMapper)
        {
            _powerPlantMapper = powerPlantMapper;
        }
        public ProductionPlan ToModel(ProductionPlanDto productionPlanDto)
        {
            return new ProductionPlan
            {
                Load = productionPlanDto.Load,
                Fuels = productionPlanDto.Fuels,
                PowerPlants = productionPlanDto.PowerPlants.Select((powerPlant) => _powerPlantMapper.ToModel(productionPlanDto.Fuels, powerPlant)).ToList()
            };
        }
    }
}

