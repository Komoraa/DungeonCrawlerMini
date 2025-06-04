using Core;

namespace Actions.Exceptions;


[Serializable]
public class InvalidAttackDefinitionException : Exception
{
	public IAttack Attack { get; }

	public InvalidAttackDefinitionException(IAttack attack)
	{
		Attack = attack;
	}
	public InvalidAttackDefinitionException(IAttack attack, string message)
		: base(message)
    {
        Attack = attack;
    }
    public InvalidAttackDefinitionException(IAttack attack, string message, Exception inner)
		: base(message, inner)
    {
        Attack = attack;
    }
}
