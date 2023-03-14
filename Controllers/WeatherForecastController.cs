/*
This code is an example of a simple ASP.NET Core Web API controller that returns a list of 
weather forecasts. Here is an explanation of the various parts of the code:

The first line of the code imports the Microsoft.AspNetCore.Mvc namespace, which provides 
the necessary classes and interfaces for building web applications using ASP.NET Core.

The next few lines define the namespace and class for the controller. 
The [ApiController] attribute is used to indicate that this controller should automatically 
infer the binding source parameters from the request's properties such as the query string, 
request body, and route data. 
The [Route("[controller]")] attribute specifies the base route of the controller. 
In this case, the route will be the name of the controller, which is "WeatherForecast".

The class contains a static array of strings called Summaries that stores various weather 
conditions.

The constructor takes an ILogger<WeatherForecastController> instance as an input parameter, 
which is used to log any exceptions or informational messages that might arise during the 
execution of the code.

The [HttpGet(Name = "GetWeatherForecast")] attribute is used to indicate that the 
Get method should respond to HTTP GET requests. 
The "Name" property of the attribute is used to give the action a unique name that can be 
used to generate a URL for the action.

The Get method returns an IEnumerable<WeatherForecast>, which is an array of objects 
containing the date, temperature, and summary for each forecast. 
The method uses the LINQ extension method Enumerable.Range to generate a sequence of 
integers from 1 to 5, and then uses the Select method to project each integer in the 
sequence into a new WeatherForecast object. 
The WeatherForecast object's properties are set using random values generated using the 
Random class's Shared property. The Date property is set using the DateOnly struct's 
FromDateTime method, which returns a new instance of the struct containing only the 
date portion of the DateTime value returned by DateTime.Now.AddDays(index). 
Finally, the ToArray method is used to convert the sequence of WeatherForecast objects 
into an array.

Overall, this code demonstrates the basics of building a simple web API using ASP.NET Core. 
It defines a controller with a single action that returns a collection of objects, 
and uses a few built-in ASP.NET Core features such as attribute routing and logging.
*/


using Microsoft.AspNetCore.Mvc;

namespace MyMicroservice.Controllers;

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
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
