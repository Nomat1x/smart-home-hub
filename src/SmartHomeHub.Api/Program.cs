using Scalar.AspNetCore;
using System.Runtime.Versioning;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();


app.MapGet("/health", () => new
{
    Status = "Healthy",
    Timestamp = DateTime.UtcNow,
    Version = "1.0.0",
    FrameworkName = ".NET 10",
})
.WithName("HealthCheck")
.WithSummary("Checks the health of the application")
.WithDescription("Returns the health status");

app.MapGet("api/status", () => new
{
    Message = "Smart Home Hub API is running",
    Environment = app.Environment.EnvironmentName,
    Features = new[]
    {
        "Device Management",
        "MQTT Integration",
        "Real-time Monitoring",
        "Automation Rules"
    }
})
.WithName("GetStatus")
.WithSummary("Get API status")
.WithDescription("Returns current API status and available features");

app.MapGet("/api/devices/{id}", (int id) => new
{
    Id = id,
    Name = $"Test Device {id}",
    Type = "Sensor",
    Status = "On"
})
.WithName("GetDevice")
.WithSummary("Get device by ID")
.WithDescription("Returns device information by ID (mock data for now)");

app.Run();
