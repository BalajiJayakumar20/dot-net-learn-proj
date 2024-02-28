using Microsoft.AspNetCore.Mvc;

namespace test_proj.Controllers;

public class Employee
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //{
        //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //    TemperatureC = Random.Shared.Next(-20, 55),
        //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //})
        //.ToArray();
        return "Hello";
    }

    [HttpGet("sample")]
    public string GetTestData()
    {
        return "Hello";
    }

    [HttpPost("submit")]
    public string SubmitForm(Employee employee)
    {
        var name = employee.Name;
        var age = employee.Age;
        return $"Hello.. Welcome {name}";
    }
}

