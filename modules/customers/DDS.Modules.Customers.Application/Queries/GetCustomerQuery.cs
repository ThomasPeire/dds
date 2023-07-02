using DDS.Modules.Customers.Application.Models;
using DDS.Modules.Customers.Application.Types;
using DDS.Modules.Customers.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DDS.Modules.Customers.Application.Queries;

[QueryType]
public static class GetCustomerQuery
{
    [GraphQLType<CustomerType>]
    public static async Task<CustomerView?> GetCustomer(
        Guid? id,
        [FromServices] ICustomerRepository repository,
        CancellationToken cancellationToken)
    {
        if (!id.HasValue)
            return null;

        return await repository.LoadViewAsync<CustomerView>(id.Value, null, cancellationToken);
    }
}