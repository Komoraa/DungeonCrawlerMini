namespace Core;

public interface IWeapon : IItem
{
    IReadOnlyList<IAttack> Attacks { get; }

    bool Has(IAttack attack);
    void Add(IAttack attack);
    bool TryAdd(IAttack attack);
    void Remove(IAttack attack);
    bool TryRemove(IAttack attack);
}
