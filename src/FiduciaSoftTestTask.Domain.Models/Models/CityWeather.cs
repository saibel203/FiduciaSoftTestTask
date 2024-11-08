using FiduciaSoftTestTask.Domain.Models.Models.WeatherItems;
using Newtonsoft.Json;

namespace FiduciaSoftTestTask.Domain.Models.Models;

public class CityWeather
{
    public string Name { get; set; } = string.Empty;

    public MainData Main { get; set; } = null!;

    [JsonProperty("sys")]
    public CountryData CountryData { get; set; } = null!;

    [JsonProperty("wind")]
    public WindData WindData { get; set; } = null!;

    [JsonProperty("weather")]
    public List<WeatherData> WeatherData { get; set; } = [];
}
