using Core;
using Items.Exceptions;

namespace Items;

public class Weapon : Item, IWeapon
{
    protected List<IAttack> _attacks = [];
    public IReadOnlyList<IAttack> Attacks
    {
        get
        {
            return _attacks.AsReadOnly();
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()} Attacks: [{string.Join(", ", Attacks)}]";
    }

    public bool Has(IAttack attack)
    {
        return Attacks.Contains(attack);
    }
    public void Add(IAttack attack)
    {
        if (Attacks.Contains(attack))
        {
            throw new AttackAlreadyAvailableException(this, attack);
        }
        _attacks.Add(attack);
    }
    public bool TryAdd(IAttack attack)
    {
        try
        {
            Add(attack);
            return true;
        }
        catch (AttackAlreadyAvailableException)
        {
            return false;
        }
    }
    public void Remove(IAttack attack)
    {
        if (!Has(attack))
        {
            throw new AttackNotAvailableException(this, attack);
        }
        _attacks.Remove(attack);
    }
    public bool TryRemove(IAttack attack)
    {
        try
        {
            Remove(attack);
            return true;
        }
        catch (AttackNotAvailableException)
        {
            return false;
        }
    }
}
