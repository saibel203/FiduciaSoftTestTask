using FiduciaSoftTestTask.Contracts.ClientAbstractions;
using FiduciaSoftTestTask.Domain.Models.IOptions;
using FiduciaSoftTestTask.Infrastructure.Clients;
using FiduciaSoftTestTask.Infrastructure.PowerShell;

namespace FiduciaSoftTestTask.Web;

public static class ConfigureServices
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        var powerShell = new PowerShellTerminal();
        powerShell.RunShellCommand("gulp watch-sass");
        powerShell.RunShellCommand("gulp watch-typescript");

        services.Configure<WeatherApiDataOptions>(
            configuration.GetSection(WeatherApiDataOptions.Section));
        
        services.AddHttpClient<IWeatherClient, WeatherClient>();

        services.AddControllersWithViews()
            .AddApplicationPart(typeof(Persistence.AssemblyReference).Assembly);
        
        return services;
    }
}