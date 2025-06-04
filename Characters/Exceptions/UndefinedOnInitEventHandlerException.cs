using Core;

namespace Characters.Exceptions;


[Serializable]
public class UndefinedOnInitEventHandlerException : Exception
{
	public ICharacter Character { get; }

	public UndefinedOnInitEventHandlerException(ICharacter character)
	{
		Character = character;
	}
	public UndefinedOnInitEventHandlerException(ICharacter character, string message)
		: base(message)
    {
        Character = character;
    }
    public UndefinedOnInitEventHandlerException(ICharacter character, string message, Exception inner)
		: base(message, inner)
    {
        Character = character;
    }
}