using DDS.Modules.Customers.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDS.Modules.Customers.Application;

public static class CustomersStartup
{
    public static IServiceCollection AddCustomerModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddMartenConfiguration(configuration);

        return services;
    }
}