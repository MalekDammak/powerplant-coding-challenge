using Microsoft.AspNetCore.Mvc;
using powerPlantCodingChallenge.Dtos;
using powerPlantCodingChallenge.Services;

namespace powerPlantCodingChallenge.Controllers;

[ApiController]
[Produces("application/json")]
[Route("/productionplan")]
public class ProductionPlanController : Controller
{

    private readonly IProductionPlanService _productionPlanService;
    private readonly ILogger<ProductionPlanController> _logger;

    public ProductionPlanController(IProductionPlanService productionPlanService, ILogger<ProductionPlanController> logger)
    {
        _productionPlanService = productionPlanService;
        _logger = logger;
    }

    [HttpPost(Name = "powerplantsproduction")]
    public IActionResult Post([FromBody] ProductionPlanDto productionPlanDto)
    {
        try
        {
            return Ok(_productionPlanService.ComputeUnitCommitment(productionPlanDto));

        }
        catch (Exception ex)
        {
            return ErrorHandler(ex);
        }
    }

    private IActionResult ErrorHandler(Exception ex)
    {
        _logger.LogError(ex.Message);
        return BadRequest(ex.Message);
    }
}

