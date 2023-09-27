using powerPlantCodingChallenge.Dtos;
using powerPlantCodingCallenge.Tests.Mocks;
using powerPlantCodingChallenge.Exceptions;
using powerPlantCodingChallenge.Mappers;
using powerPlantCodingChallenge.Services;
using PowerPlantCodingChallenge.Tests.Mocks;
using Moq;
using FluentAssertions;
namespace powerPlantCodingCallenge.Tests;

public class ProductionPlanServiceTests
{
    private readonly ProductionPlanService _productionPlanService;

    private readonly Mock<IProductionPlanMapper> _productionPlanMapperMock = new Mock<IProductionPlanMapper>() { CallBase = true };

    public ProductionPlanServiceTests()
    {
        _productionPlanService = new ProductionPlanService(_productionPlanMapperMock.Object);

    }
    [Fact]
    public void TestProductionPlanComputeUnitCommitment_Succeed()
    {
        _productionPlanMapperMock.Setup(mapper => mapper.ToModel(It.IsAny<ProductionPlanDto>())).Returns(ProductionPlanMock.GetMock(910));

        List<PowerPlantOutputDto> result = _productionPlanService.ComputeUnitCommitment(ProductionPlanDtoMock.GetMock(910));
        List<PowerPlantOutputDto> expectedResult = ProductionPlanOuputMock.GetMock();
        expectedResult.Should().BeEquivalentTo(result);

    }
    [Fact]
    public void TestProductionPlanComputeUnitCommitment_ThrowComputeException()
    {
        _productionPlanMapperMock.Setup(mapper => mapper.ToModel(It.IsAny<ProductionPlanDto>())).Returns(ProductionPlanMock.GetMock(100000));
        Assert.Throws<ComputeException>(() => _productionPlanService.ComputeUnitCommitment(ProductionPlanDtoMock.GetMock(100000)));
    }
}
