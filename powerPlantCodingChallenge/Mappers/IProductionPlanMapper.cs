using powerPlantCodingChallenge.Dtos;
using powerPlantCodingChallenge.Models;

namespace powerPlantCodingChallenge.Mappers
{
    public interface IProductionPlanMapper
    {
        ProductionPlan ToModel(ProductionPlanDto productionPlanDto);

    }
}

