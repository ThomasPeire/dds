namespace DDS.BuildingBlocks.Domain;

public interface IRepository
{
    void AppendChanges(AggregateRoot aggregate);
    Task SaveChangesAsync(CancellationToken ct = default);

    Task<T> LoadAsync<T>(
        string id,
        int? version = null,
        CancellationToken ct = default
    ) where T : AggregateRoot;
}