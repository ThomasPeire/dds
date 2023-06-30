using Marten;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDS.Modules.Customers.Infrastructure;

public static class CustomersStartup
{
    public static IServiceCollection AddMartenConfiguration(this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddMarten(options =>
            {
                options.Connection(configuration.GetConnectionString("CustomerDB")!);
            })
            .OptimizeArtifactWorkflow();

        return services;
    }
}