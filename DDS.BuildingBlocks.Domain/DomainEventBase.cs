namespace DDS.BuildingBlocks.Domain;

public record DomainEventBase(Guid Id) : IDomainEvent
{
}