namespace Core;

public interface IRoom
{
    Guid Id { get; }
    string? Name { get; }
    string? Description { get; }

    IReadOnlyList<ICharacter> Enemies { get; }
    IReadOnlyList<IItem> Items { get; }

    bool Has(IItem item);
    void Add(IItem item);
    bool TryAdd(IItem item);
    void Remove(IItem item);
    bool TryRemove(IItem item);

    bool Has(ICharacter character);
    void Add(ICharacter character);
    bool TryAdd(ICharacter character);
    void Remove(ICharacter character);
    bool TryRemove(ICharacter character);
}
