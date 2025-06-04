using Core;

namespace Characters.Exceptions;


[Serializable]
public class AttackAlreadyAvailableException : Exception
{
    public ICharacter Character { get; }
    public IAttack Attack { get; }

    public AttackAlreadyAvailableException(ICharacter character, IAttack attack)
    {
        Character = character;
        Attack = attack;
    }
    public AttackAlreadyAvailableException(ICharacter character, IAttack attack, string message)
        : base(message)
    {
        Character = character;
        Attack = attack;
    }
    public AttackAlreadyAvailableException(ICharacter character, IAttack attack, string message, Exception inner)
        : base(message, inner)
    {
        Character = character;
        Attack = attack;
    }
}