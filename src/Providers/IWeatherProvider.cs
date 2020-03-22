using System.Collections.Generic;
using MemeSauce.Models;

namespace MemeSauce.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
