using FiduciaSoftTestTask.Domain.Models.Models;

namespace FiduciaSoftTestTask.Contracts.ClientAbstractions;

public interface IWeatherClient
{
    Task<CityWeather> GetWeatherByCity(string? cityName);
}
