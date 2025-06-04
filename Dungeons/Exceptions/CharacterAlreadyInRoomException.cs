using Core;

namespace Dungeons.Exceptions;


[Serializable]
public class CharacterAlreadyInRoomException : Exception
{
	public IRoom Room { get; }
	public ICharacter Character { get; }

	public CharacterAlreadyInRoomException(IRoom room, ICharacter character)
	{
		Room = room;
		Character = character;
	}
	public CharacterAlreadyInRoomException(IRoom room, ICharacter character, string message)
		: base(message)
    {
        Room = room;
        Character = character;
    }
    public CharacterAlreadyInRoomException(IRoom room, ICharacter character, string message, Exception inner)
		: base(message, inner)
    {
        Room = room;
        Character = character;
    }
}
