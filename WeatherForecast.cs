/*This code defines a C# class called WeatherForecast in the MyMicroservice namespace. 
Here's what each part of the class does:

public DateOnly Date { get; set; }: 
This is a public property called Date of type DateOnly. 
The get; set; syntax indicates that this property can be both read and written from outside 
the class.

public int TemperatureC { get; set; }: 
This is another public property called TemperatureC of type int. 
Like Date, it has both a getter and a setter.

public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);: 
This is a public read-only property called TemperatureF that calculates the Fahrenheit 
equivalent of TemperatureC. The => syntax is used to define a computed property, 
which means that its value is calculated based on the value of other properties. 
In this case, the formula used to calculate the Fahrenheit temperature 
is (TemperatureC / 0.5556) + 32.

public string? Summary { get; set; }: 
This is another public property called Summary of type string?. 
The ? indicates that this property is nullable, which means that it can have a value of null. 
Like the other properties, it has both a getter and a setter.

Overall, this code defines a simple class that represents a weather forecast 
with properties for the date, temperature in Celsius and Fahrenheit, and a summary.
*/

namespace MyMicroservice;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
