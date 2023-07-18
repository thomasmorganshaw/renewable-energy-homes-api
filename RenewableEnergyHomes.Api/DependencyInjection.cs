using RenewableEnergyHomes.Api.Application.CommandHandlers;
using RenewableEnergyHomes.Api.Infrastructure;
using RenewableEnergyHomes.Domain.Services;
using RenewableEnergyHomes.Infrastructure.Services;
using RenewableEnergyHomes.Infrastructure.Repos;
using RenewableEnergyHomes.Domain.Repos;

namespace RenewableEnergyHomes.Api
{
    public static class DependencyInjection
    {
        internal static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IPostcodeService, PostcodeService>(client =>
            {
                client.BaseAddress = new Uri(configuration["ConnectedServices:PostcodesService"] ?? string.Empty);
            });

            services.AddScoped<IPropertyRepo, PropertyRepo>();
            services.AddScoped<IPropertySearchHandler, PropertySearchHandler>();
        }
    }
}
