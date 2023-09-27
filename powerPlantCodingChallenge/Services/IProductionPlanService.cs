using powerPlantCodingChallenge.Dtos;

namespace powerPlantCodingChallenge.Services
{
    public interface IProductionPlanService
    {
        List<PowerPlantOutputDto> ComputeUnitCommitment(ProductionPlanDto productionPlanDto);
    }
}

