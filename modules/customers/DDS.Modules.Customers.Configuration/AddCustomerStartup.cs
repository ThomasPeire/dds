using DDS.Modules.Customers.Application.Queries;
using DDS.Modules.Customers.Domain;
using DDS.Modules.Customers.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDS.Modules.Customers.Configuration;

public static class CustomersStartup
{
    public static IServiceCollection AddCustomerModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddMartenConfiguration(configuration)
            .AddCustomerRepository()
            .AddGraphQl();

        return services;
    }

    private static IServiceCollection AddCustomerRepository(this IServiceCollection services)
    {
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        return services;
    }
    
    private static IServiceCollection AddGraphQl(this IServiceCollection services)
    {
        services.AddGraphQLServer("Customers")
            .AddQueryType()
            .AddTypeExtension(typeof(GetCustomerQuery));
        
        return services;
    }
}