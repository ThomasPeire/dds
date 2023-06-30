
using Newtonsoft.Json;

namespace DDS.BuildingBlocks.Domain;

public abstract class AggregateRoot
{
    public Guid Id { get; protected set; }
    public long Version { get; set; }

    [JsonIgnore]
    private readonly List<object> _uncommittedEvents = new();

    public IEnumerable<object> GetUncommittedEvents()
    {
        return _uncommittedEvents;
    }

    public void ClearUncommittedEvents()
    {
        _uncommittedEvents.Clear();
    }

    protected void AddUncommittedEvent(object @event)
    {
        _uncommittedEvents.Add(@event);
    }
}
