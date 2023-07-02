using DDS.BuildingBlocks.Application;
using DDS.BuildingBlocks.Domain;
using Marten;

namespace DDS.BuildingBlocks.Infrastructure;

public class Repository : IRepository
{
    private readonly IDocumentSession _session;

    public Repository(IDocumentSession session)
    {
        _session = session;
    }

    public void AppendChanges(AggregateRoot aggregate)
    {
        var events = aggregate.GetDomainEvents().ToArray();
        _session.Events.Append(aggregate.Id, aggregate.Version, events);
    }

    public async Task SaveChangesAsync(CancellationToken ct = default)
    {
        await _session.SaveChangesAsync(ct);
    }

    public async Task<T> LoadAsync<T>(
        Guid id,
        int? version = null,
        CancellationToken ct = default
    ) where T : AggregateRoot
    {
        var aggregate = await _session.Events.AggregateStreamAsync<T>(id, version ?? 0, token: ct);
        return aggregate ?? throw new InvalidOperationException($"No aggregate by id {id}");
    }
    public async Task<T> LoadViewAsync<T>(
        Guid id,
        int? version = null,
        CancellationToken ct = default
    ) where T : class
    {
        var aggregate = await _session.Events.AggregateStreamAsync<T>(id, version ?? 0, token: ct);
        return aggregate ?? throw new InvalidOperationException($"No stream by id {id}");
    }
}