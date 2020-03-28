using System.Collections.Generic;
using CovidVisual.Models;

namespace CovidVisual.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
