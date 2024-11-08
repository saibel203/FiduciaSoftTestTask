namespace FiduciaSoftTestTask.Domain.Models.IOptions;

public class WeatherApiDataOptions
{
    public const string Section = "WeatherApiData";

    public string ApiKey { get; set; } = string.Empty;
    public string BaseAddress { get; set; } = string.Empty;
}