using DDS.BuildingBlocks.Domain;
using DDS.Modules.Customers.Domain.Events;

namespace DDS.Modules.Customers.Domain;

public class Customer : AggregateRoot, IAuditable
{
    private Customer()
    {
        RegisterEventHandler<CustomerCreatedDomainEvent>(Apply);
    }

    private void Apply(CustomerCreatedDomainEvent @event)
    {
        Id = @event.Id;

        CreatedOn = @event.CreatedOn;
        UpdatedOn = @event.CreatedOn;
        CreatedBy = @event.CreatedBy;
        UpdatedBy = @event.CreatedBy;
    }

    public static Customer Create(Guid id)
    {
        var customer = new Customer();
        var @event = new CustomerCreatedDomainEvent(id, DateTime.UtcNow, Guid.Empty);
        customer.HandleEvent(@event);
        return customer;
    }

    public DateTime CreatedOn { get; protected set; }
    public DateTime UpdatedOn { get; protected set; }
    public Guid CreatedBy { get; protected set; }
    public Guid UpdatedBy { get; protected set; }
}