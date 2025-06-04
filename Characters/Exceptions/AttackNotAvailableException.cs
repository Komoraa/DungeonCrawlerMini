using Core;

namespace Characters.Exceptions;


[Serializable]
public class AttackNotAvailableException : Exception
{
    public ICharacter Character { get; }
    public IAttack Attack { get; }

    public AttackNotAvailableException(ICharacter character, IAttack attack)
    {
        Character = character;
        Attack = attack;
    }
    public AttackNotAvailableException(ICharacter character, IAttack attack, string message)
        : base(message)
    {
        Character = character;
        Attack = attack;
    }
    public AttackNotAvailableException(ICharacter character, IAttack attack, string message, Exception inner)
        : base(message, inner)
    {
        Character = character;
        Attack = attack;
    }
}
