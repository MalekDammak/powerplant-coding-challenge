using powerPlantCodingChallenge.Constant;
using powerPlantCodingChallenge.Dtos;
using powerPlantCodingChallenge.Exceptions;
using powerPlantCodingChallenge.Mappers;
using powerPlantCodingChallenge.Models;

namespace powerPlantCodingChallenge.Services
{
    /// <summary>
    ///  Production plan services
    /// </summary>
    public class ProductionPlanService : IProductionPlanService
    {

        private readonly IProductionPlanMapper _productionPlanMapper;

        public ProductionPlanService(IProductionPlanMapper productionPlanMapper)
        {
            _productionPlanMapper = productionPlanMapper;
        }

        /// <summary>
        /// Compute unit commitment
        /// </summary>
        /// <param name="productionPlanDto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<PowerPlantOutputDto> ComputeUnitCommitment(ProductionPlanDto productionPlanDto)
        {

            ProductionPlan productionPlan = _productionPlanMapper.ToModel(productionPlanDto);

            productionPlan.PowerPlants = MeritOrder(productionPlan.PowerPlants);

            return ComputeProduction(productionPlan);

        }
        /// <summary>
        /// Order Power plants list by price then by pMin
        /// </summary>
        /// <param name="powerPlants"></param>
        /// <returns></returns>
        private List<PowerPlant> MeritOrder(List<PowerPlant> powerPlants)
        {

            powerPlants = powerPlants.OrderBy((PowerPlant arg) => arg.EnergySource.Price).ThenBy((powerPlant) => powerPlant.Pmin).ToList();
            return powerPlants;
        }
        /// <summary>
        /// Compute production
        /// </summary>
        /// <param name="productionPlan"></param>
        /// <returns></returns>
        private List<PowerPlantOutputDto> ComputeProduction(ProductionPlan productionPlan)
        {
            decimal currentProduction = 0;
            decimal powerToBeProducedByPowerPlant = 0;
            List<PowerPlantOutputDto> powerPlantOutputDtos = new List<PowerPlantOutputDto>();

            productionPlan.PowerPlants.ForEach((powerPlant) =>
            {
                if (productionPlan.Load - currentProduction >= powerPlant.Pmin)
                {
                    powerToBeProducedByPowerPlant = Math.Min(powerPlant.EnergySource.MaxPower, productionPlan.Load - currentProduction);
                    currentProduction += powerToBeProducedByPowerPlant;
                    powerPlantOutputDtos.Add(new PowerPlantOutputDto()
                    {
                        Name = powerPlant.Name,
                        P = powerToBeProducedByPowerPlant
                    });
                }
                else
                {
                    powerPlantOutputDtos.Add(new PowerPlantOutputDto()
                    {
                        Name = powerPlant.Name,
                        P = 0
                    });
                }

            });

            if (currentProduction < productionPlan.Load)
            {
                throw new ComputeException(MessageConstants.CannotGeneratePower);
            }

            return powerPlantOutputDtos;
        }

    }
}

