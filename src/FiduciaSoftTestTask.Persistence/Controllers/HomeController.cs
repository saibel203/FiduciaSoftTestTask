using FiduciaSoftTestTask.Contracts.ClientAbstractions;
using FiduciaSoftTestTask.Presentation.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace FiduciaSoftTestTask.Presentation.Controllers;

public class HomeController : BaseController
{
    private readonly IWeatherClient _weatherClient;

    public HomeController(IWeatherClient weatherClient)
    {
        _weatherClient = weatherClient;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> WeatherDetail(string cityName)
    {
        var weatherResult = await _weatherClient.GetWeatherByCity(cityName);

        return Ok(weatherResult);
    }
}