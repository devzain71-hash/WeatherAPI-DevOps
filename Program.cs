var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5000");

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weather", (string city = "Islamabad") =>
{
    var weatherData = new Dictionary<string, (int temp, int humidity, string description)>
    {
        { "Islamabad", (28, 60, "Warm and Pleasant") },
        { "Karachi", (32, 75, "Hot and Humid") },
        { "Lahore", (35, 65, "Very Hot") },
        { "Dubai", (38, 40, "Very Hot and Dry") },
        { "London", (15, 70, "Cool and Cloudy") },
        { "New York", (22, 65, "Mild and Sunny") }
    };

    if (weatherData.TryGetValue(city, out var weather))
    {
        return Results.Ok(new
        {
            city = city,
            temperature = weather.temp,
            humidity = weather.humidity,
            description = weather.description,
            unit = "Celsius",
            timestamp = DateTime.UtcNow
        });
    }

    return Results.NotFound(new { error = $"Weather data for {city} not found" });
})
.WithName("GetWeather")
.WithOpenApi();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
