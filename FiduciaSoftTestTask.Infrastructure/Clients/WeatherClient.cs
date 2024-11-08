using FiduciaSoftTestTask.Contracts.ClientAbstractions;
using FiduciaSoftTestTask.Domain.Models.IOptions;
using FiduciaSoftTestTask.Domain.Models.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FiduciaSoftTestTask.Infrastructure.Clients;

public class WeatherClient : IWeatherClient
{
    private readonly HttpClient _httpClient;
    private readonly WeatherApiDataOptions _weatherApiDataOptions;

    public WeatherClient(HttpClient httpClient, IOptions<WeatherApiDataOptions> weatherApiDataOptions)
    {
        _weatherApiDataOptions = weatherApiDataOptions.Value;

        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(_weatherApiDataOptions.BaseAddress);
    }

    public async Task<CityWeather> GetWeatherByCity(string? cityName)
    {
        var response = await _httpClient.GetAsync($"weather?q={cityName}&appid={_weatherApiDataOptions.ApiKey}&units=metric");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<CityWeather>(content);

        return result;
    }
}
