using DDS.BuildingBlocks.Domain;

namespace DDS.Modules.Customers.Domain.Events;

public record CustomerCreatedDomainEvent(Guid Id, DateTime CreatedOn, Guid CreatedBy) : DomainEventBase(Id)
{
}