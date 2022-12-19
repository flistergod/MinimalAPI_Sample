using FluentValidation;
using F1Emu.Api.Domain.Laps;
using F1Emu.Api.Infrastructure.SqlLap;

var builder = WebApplication.CreateBuilder(args);

//buscar a connection string ao json de configs
var storageConnectionString = builder.Configuration.GetConnectionString("SqlServer");

//injecao dependencia para instaciar a bd repository
builder.Services.AddSingleton<ILapRepository>(new SqlLapRepository(storageConnectionString));

var app = builder.Build();



app.MapGet("/", () => "Welcome to F1 Emu!");


/*logica*/

app.MapPost("/laps", async (AddLapRequest addLapRequest, ILapRepository lapRepository) =>
{
    Lap lap = new()
    {
        Id = Guid.NewGuid(),
        DriverName = addLapRequest.DriverName,
        LapIndex = addLapRequest.LapIndex,
        Sector = addLapRequest.Sector,
        CreatedOn = DateTime.UtcNow,
        ElapsedTime = TimeSpan.Parse($"00:{addLapRequest.ElapsedTime}"),
        SectorTime = TimeSpan.Parse($"00:{addLapRequest.SectorTime}")
    };
    var resultLap = await lapRepository.Add(lap);
    return Results.Ok(resultLap);
});


app.Run();
