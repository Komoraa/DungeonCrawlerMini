using Core;

namespace Items.Exceptions;


[Serializable]
public class AttackAlreadyAvailableException : Exception
{
	public IItem Item { get; }
	public IAttack Attack { get; }

	public AttackAlreadyAvailableException(IItem item, IAttack attack)
	{
		Item = item;
		Attack = attack;
	}
	public AttackAlreadyAvailableException(IItem item, IAttack attack, string message)
		: base(message)
    {
        Item = item;
        Attack = attack;
    }
    public AttackAlreadyAvailableException(IItem item, IAttack attack, string message, Exception inner)
		: base(message, inner)
    {
        Item = item;
        Attack = attack;
    }
}
