using BirdAPI.ApiService.BackgroundServices;
using BirdAPI.ApiService.Database;
using BirdAPI.Data.Repositories;

// ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
// ┃  Application Initialization         ┃
// ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
var builder = WebApplication.CreateBuilder(args);

// ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
// ┃  Service Configuration              ┃
// ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
builder.AddNpgsqlDbContext<ApplicationDbContext>("birdapi");
builder.AddServiceDefaults();
builder.Services.AddProblemDetails();
builder.Services.AddControllers(); // Registriert alle Controller
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new() { Title = "BirdAPI.ApiService", Version = "v1" });
});
builder.Services.AddHttpClient();
builder.Services.AddHostedService<XenoCantoFetcher>();

var Configuration = builder.Configuration;

var app = builder.Build();

// ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
// ┃  Middleware Configuration           ┃
// ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();

// ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
// ┃  Endpoint Mapping                   ┃
// ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
app.MapControllers(); // Registriert alle Endpunkte aus den Controllern
app.MapDefaultEndpoints();

// ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
// ┃  Application Run                    ┃
// ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
app.Run();
