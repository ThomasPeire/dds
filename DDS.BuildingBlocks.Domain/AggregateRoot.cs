using Newtonsoft.Json;

namespace DDS.BuildingBlocks.Domain;

public abstract class AggregateRoot
{
    public Guid Id { get; protected set; }
    public long Version { get; set; }

    [JsonIgnore] private readonly List<IDomainEvent> _domainEvents = new();

    [JsonIgnore] private readonly IDictionary<Type, List<Action<IDomainEvent>>> _eventHandlers =
        new Dictionary<Type, List<Action<IDomainEvent>>>();

    protected void RegisterEventHandler<T>(Action<T> eventHandler) where T : class, IDomainEvent
    {
        if (_eventHandlers.ContainsKey(typeof(T)))
            _eventHandlers[typeof(T)].Add(ActionToRegister);
        else
            _eventHandlers.Add(typeof(T), new List<Action<IDomainEvent>> { ActionToRegister });

        void ActionToRegister(IDomainEvent domainEvent) => eventHandler(domainEvent as T ?? throw new
            InvalidOperationException());
    }

    protected void HandleEvent<T>(T @event) where T : class, IDomainEvent
    {
        AddDomainEvent(@event);
        if (!_eventHandlers.ContainsKey(@event.GetType()))
            throw new InvalidOperationException($"No event handler registered for {@event.GetType().Name}");

        foreach (var handler in _eventHandlers[@event.GetType()])
        {
            handler(@event);
        }
    }

    public IEnumerable<IDomainEvent> GetDomainEvents() => _domainEvents.AsReadOnly();

    private void AddDomainEvent(IDomainEvent @event) => _domainEvents.Add(@event);
}