using powerPlantCodingChallenge.Mappers;
using powerPlantCodingChallenge.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Services
builder.Services.AddSingleton<IProductionPlanService, ProductionPlanService>();
builder.Services.AddSingleton<IPowerPlantMapper, PowerPlantMapper>(); ;
// Mappers
builder.Services.AddSingleton<IProductionPlanMapper, ProductionPlanMapper>();
// Ports
builder.WebHost.UseUrls("http://*:8888");
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();

