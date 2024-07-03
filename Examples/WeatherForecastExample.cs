using Demoo.Models;
using Microsoft.VisualBasic;
using Swashbuckle.AspNetCore.Filters;

namespace Demoo.Examples
{
    public class WeatherForecastExample : IMultipleExamplesProvider<WeatherForecast>
    {
        public IEnumerable<SwaggerExample<WeatherForecast>> GetExamples()
        {
            yield return SwaggerExample.Create(
                "Example 1",
                new WeatherForecast()
                {
                    Date = DateOnly.MaxValue,
                    TemperatureC = 70,
                    Summary = "hot"

                });
            yield return SwaggerExample.Create(
                "Example 2",
                new WeatherForecast()
                {
                    Date = DateOnly.MinValue,
                    TemperatureC = -15,
                    Summary = "Cold"
                });
        }
    }
}
