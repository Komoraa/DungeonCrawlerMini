using Core;
using Dungeons.Exceptions;

namespace Dungeons;

public class Room : IRoom, IEquatable<Room>
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name
    {
        get;
        set
        {
            field = value ?? nameof(Room);
        }
    } = nameof(Room);
    public string? Description
    {
        get;
        set
        {
            field = value ?? nameof(Room);
        }
    } = nameof(Room);

    public bool Visited { get; set; }

    protected List<ICharacter> _enemies = [];
    public IReadOnlyList<ICharacter> Enemies
    {
        get
        {
            return _enemies.AsReadOnly();
        }
    }

    protected List<IItem> _items = [];
    public IReadOnlyList<IItem> Items
    {
        get
        {
            return _items.AsReadOnly();
        }
    }

    public override string ToString()
    {
        string enemyCount;
        if (Enemies.Count == 1) enemyCount = "1 Enemy";
        else enemyCount = $"{Enemies.Count} Enemies";

        string output = $"{Name} ({enemyCount})";
        if (Visited) output += " (Visited)";

        return output;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj);
    }

    public bool Equals(Room? other)
    {
        return Id == other?.Id;
    }
    public static bool operator ==(Room left, Room right)
    {
        return left.Id == right.Id;
    }
    public static bool operator !=(Room left, Room right)
    {
        return left.Id != right.Id;
    }

    public bool Has(IItem item)
    {
        return Items.Contains(item);
    }
    public void Add(IItem item)
    {
        if (Has(item))
        {
            throw new ItemAlreadyInRoomException(this, item);
        }
        _items.Add(item);
    }
    public bool TryAdd(IItem item)
    {
        try
        {
            Add(item);
            return true;
        }
        catch (ItemAlreadyInRoomException)
        {
            return false;
        }
    }
    public void Remove(IItem item)
    {
        if (!Has(item))
        {
            throw new ItemNotInRoomException(this, item);
        }
        _items.Remove(item);
    }
    public bool TryRemove(IItem item)
    {
        try
        {
            Remove(item);
            return true;
        }
        catch (ItemNotInRoomException)
        {
            return false;
        }
    }

    public bool Has(ICharacter character)
    {
        return Enemies.Contains(character);
    }
    public void Add(ICharacter character)
    {
        if (Has(character))
        {
            throw new CharacterAlreadyInRoomException(this, character);
        }
        _enemies.Add(character);
    }
    public bool TryAdd(ICharacter character)
    {
        try
        {
            Add(character);
            return true;
        }
        catch (CharacterAlreadyInRoomException)
        {
            return false;
        }
    }
    public void Remove(ICharacter character)
    {
        if (!Has(character))
        {
            throw new CharacterNotInRoomException(this, character);
        }
        _enemies.Remove(character);
    }
    public bool TryRemove(ICharacter character)
    {
        try
        {
            Remove(character);
            return true;
        }
        catch (CharacterNotInRoomException)
        {
            return false;
        }
    }
}
