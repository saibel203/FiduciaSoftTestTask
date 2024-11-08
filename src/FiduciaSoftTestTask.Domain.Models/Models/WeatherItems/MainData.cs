using Newtonsoft.Json;

namespace FiduciaSoftTestTask.Domain.Models.Models.WeatherItems;

public class MainData
{
    [JsonProperty("temp")]
    public double Temperature { get; set; }
    
    [JsonProperty("feels_like")]
    public double FeelsLikeTemperature { get; set; }

    [JsonProperty("temp_min")]
    public double MinTemperature { get; set; }

    [JsonProperty("temp_max")]
    public double MaxTemperature { get; set; }

    public int Humidity { get; set; }
}
