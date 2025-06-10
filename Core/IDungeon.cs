namespace Core;

public interface IDungeon
{
    Guid Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }

    IReadOnlyList<IRoom> Rooms { get; }
    IReadOnlyDictionary<IRoom, IReadOnlyList<IRoom>> ConnectionMap { get; }

    bool Has(IRoom room);
    void Add(IRoom room);
    bool TryAdd(IRoom room);
    void Remove(IRoom room);
    bool TryRemove(IRoom room);

    void Connect(IRoom origin, IRoom destination, bool bidirectional = true);
    bool TryConnect(IRoom origin, IRoom destination, bool bidirectional = true);
    void Disconnect(IRoom origin, IRoom destination, bool bidirectional = true);
    bool TryDisconnect(IRoom origin, IRoom destination, bool bidirectional = true);
}
