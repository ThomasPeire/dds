using DDS.Modules.Customers.Application.Models;
using DDS.Modules.Customers.Domain.Events;
using Marten.Events.Aggregation;

namespace DDS.Modules.Customers.Application.Projections;

public class CustomerViewProjection : SingleStreamProjection<CustomerView>
{
    public CustomerViewProjection()
    {
    }

    public CustomerView Create(CustomerCreatedDomainEvent @event) =>
        new()
        {
            Id = @event.Id
        };
}