using DealDomain.Abstractions.Repositories;
using Infractucture.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infractucture.Persistance;

public static class Entry
{
    public static IServiceCollection ConfigurePersistance(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddScoped<IDealsRepository, DealsRepository>()
            .AddScoped<IRealtorsRepository, RealtorsRepository>()
            .AddScoped<ISourcesRepository, SourcesRepository>();

        services.AddDbContext<DealsDbContext>(
            options => options.UseNpgsql(configuration.GetConnectionString("Postgre"))
            );

        return services;
    }
}
