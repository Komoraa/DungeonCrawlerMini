using Core;

namespace Dungeons.Exceptions;


[Serializable]
public class CharacterNotInRoomException : Exception
{
    public IRoom Room { get; }
    public ICharacter Character { get; }

    public CharacterNotInRoomException(IRoom room, ICharacter character)
    {
        Room = room;
        Character = character;
    }
    public CharacterNotInRoomException(IRoom room, ICharacter character, string message)
        : base(message)
    {
        Room = room;
        Character = character;
    }
    public CharacterNotInRoomException(IRoom room, ICharacter character, string message, Exception inner)
        : base(message, inner)
    {
        Room = room;
        Character = character;
    }
}
