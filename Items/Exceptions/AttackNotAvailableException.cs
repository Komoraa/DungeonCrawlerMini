using Core;

namespace Items.Exceptions;


[Serializable]
public class AttackNotAvailableException : Exception
{
    public IItem Item { get; }
    public IAttack Attack { get; }

    public AttackNotAvailableException(IItem item, IAttack attack)
    {
        Item = item;
        Attack = attack;
    }
    public AttackNotAvailableException(IItem item, IAttack attack, string message)
        : base(message)
    {
        Item = item;
        Attack = attack;
    }
    public AttackNotAvailableException(IItem item, IAttack attack, string message, Exception inner)
        : base(message, inner)
    {
        Item = item;
        Attack = attack;
    }
}
