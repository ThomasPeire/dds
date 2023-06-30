using DDS.BuildingBlocks.Domain;
using Marten;

namespace DDS.BuildingBlocks.Infrastructure;

public sealed class Repository
{
    private readonly IDocumentStore store;

    public Repository(IDocumentStore store)
    {
        this.store = store;
    }

    public async Task StoreAsync(AggregateRoot aggregate, CancellationToken ct = default)
    {
        await using var session = await store.LightweightSerializableSessionAsync(token: ct);
        // Take non-persisted events, push them to the event stream, indexed by the aggregate ID
        var events = aggregate.GetUncommittedEvents().ToArray();
        session.Events.Append(aggregate.Id, aggregate.Version, events);
        await session.SaveChangesAsync(ct);
        // Once successfully persisted, clear events from list of uncommitted events
        aggregate.ClearUncommittedEvents();
    }

    public async Task<T> LoadAsync<T>(
        string id,
        int? version = null,
        CancellationToken ct = default
    ) where T : AggregateRoot
    {
        await using var session = await store.LightweightSerializableSessionAsync(token: ct);
        var aggregate = await session.Events.AggregateStreamAsync<T>(id, version ?? 0, token: ct);
        return aggregate ?? throw new InvalidOperationException($"No aggregate by id {id}");
    }
}