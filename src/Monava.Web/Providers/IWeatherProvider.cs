using System.Collections.Generic;
using Monava.Web.Models;

namespace Monava.Web.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
