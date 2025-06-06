using Core;
using Dungeons.Exceptions;

namespace Dungeons;

public class Dungeon : IDungeon, IEquatable<Dungeon>
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name
    {
        get;
        set
        {
            field = value ?? nameof(Dungeon);
        }
    } = nameof(Dungeon);
    public string? Description
    {
        get;
        set
        {
            field = value ?? nameof(Dungeon);
        }
    } = nameof(Dungeon);

    protected List<IRoom> _rooms = [];
    public IReadOnlyList<IRoom> Rooms
    {
        get
        {
            return _rooms.AsReadOnly();
        }
    }

    protected Dictionary<IRoom, List<IRoom>> _connectionMap = [];
    public IReadOnlyDictionary<IRoom, IReadOnlyList<IRoom>> ConnectionMap
    {
        get
        {
            Dictionary<IRoom, IReadOnlyList<IRoom>> connectionMap = [];
            foreach (var kvp in _connectionMap)
            {
                connectionMap[kvp.Key] = kvp.Value.AsReadOnly();
            }
            return connectionMap.AsReadOnly();
        }
    }

    public override string ToString()
    {
        var connectionMap = from kvp in ConnectionMap
                            let rc = string.Join(", ", from r in kvp.Value select r.Name)
                            select $"[{kvp.Key}: [{rc}]]";
        return $"{Name}, Description: {Description} Rooms: [{string.Join(", ", Rooms)}], Connection Map: [{string.Join(", ", connectionMap)}]";
    }
    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        return ToString().Equals(obj?.ToString());
    }

    public bool Equals(Dungeon? other)
    {
        return Id == other?.Id;
    }
    public static bool operator ==(Dungeon left, Dungeon right)
    {
        return left.Id == right.Id;
    }
    public static bool operator !=(Dungeon left, Dungeon right)
    {
        return left.Id != right.Id;
    }

    public bool Has(IRoom room)
    {
        return Rooms.Contains(room);
    }
    public void Add(IRoom room)
    {
        if (Has(room))
        {
            throw new RoomAlreadyInDungeonException(this, room);
        }
        _rooms.Add(room);
        _connectionMap[room] = [];
    }
    public bool TryAdd(IRoom room)
    {
        try
        {
            Add(room);
            return true;
        }
        catch (RoomAlreadyInDungeonException)
        {
            return false;
        }
    }
    public void Remove(IRoom room)
    {
        if (!Has(room))
        {
            throw new RoomNotInDungeonException(this, room);
        }
        foreach (var kvp in ConnectionMap)
        {
            if (kvp.Value.Contains(room))
            {
                throw new CannotRemoveRoomConnectedToRoomsInDungeonException(this, room);
            }
        }
        _rooms.Remove(room);
        _connectionMap.Remove(room);
    }
    public bool TryRemove(IRoom room)
    {
        try
        {
            Remove(room);
            return true;
        }
        catch (RoomNotInDungeonException)
        {
            return false;
        }
        catch (CannotRemoveRoomConnectedToRoomsInDungeonException)
        {
            return false;
        }
    }

    public void Connect(IRoom origin, IRoom destination, bool bidirectional = true)
    {
        if (ReferenceEquals(origin, destination))
        {
            throw new CannotConnectRoomToSelfException(origin);
        }
        if (!Rooms.Contains(origin))
        {
            throw new RoomNotInDungeonException(this, origin);
        }
        if (ConnectionMap[origin].Contains(destination))
        {
            throw new RoomAlreadyConnectedToRoomException(this, origin, destination);
        }
        if (bidirectional)
        {
            if (!Rooms.Contains(destination))
            {
                throw new RoomNotInDungeonException(this, destination);
            }
            if (ConnectionMap[destination].Contains(origin))
            {
                throw new RoomAlreadyConnectedToRoomException(this, destination, origin);
            }
            _connectionMap[destination].Add(origin);
        }
        _connectionMap[origin].Add(destination);
    }
    public bool TryConnect(IRoom origin, IRoom destionation, bool bidirectional = true)
    {
        try
        {
            Connect(origin, destionation, bidirectional);
            return true;
        }
        catch (RoomAlreadyConnectedToRoomException)
        {
            return false;
        }
    }
    public void Disconnect(IRoom origin, IRoom destination, bool bidirectional = true)
    {
        if (ReferenceEquals(origin, destination))
        {
            throw new CannotDisconnectRoomFromSelfException(origin);
        }
        if (!ConnectionMap[origin].Contains(destination))
        {
            throw new RoomNotConnectedToRoomException(this, origin, destination);
        }
        if (bidirectional)
        {
            if (!ConnectionMap[destination].Contains(origin))
            {
                throw new RoomNotConnectedToRoomException(this, destination, origin);
            }
            _connectionMap[destination].Remove(origin);
        }
        _connectionMap[origin].Remove(destination);
    }
    public bool TryDisconnect(IRoom origin, IRoom destination, bool bidirectional = true)
    {
        try
        {
            Disconnect(origin, destination, bidirectional);
            return true;
        }
        catch (RoomNotConnectedToRoomException)
        {
            return false;
        }
    }
}
