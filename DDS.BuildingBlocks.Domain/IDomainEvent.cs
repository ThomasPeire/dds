namespace DDS.BuildingBlocks.Domain;

public interface IDomainEvent
{
    Guid Id { get; }
}