using DDS.Modules.Customers.Application.Projections;
using Marten;
using Marten.Events.Projections;
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
                options.Projections.Add<CustomerViewProjection>(ProjectionLifecycle.Inline);
            })
            .UseLightweightSessions()
            .OptimizeArtifactWorkflow();

        return services;
    }
}