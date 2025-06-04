using Core;

namespace Dungeons.Exceptions;


[Serializable]
public class CannotDisconnectRoomFromSelfException : Exception
{
	public IRoom Room { get; }

	public CannotDisconnectRoomFromSelfException(IRoom room)
	{
		Room = room;
	}
	public CannotDisconnectRoomFromSelfException(IRoom room, string message)
		: base(message)
    {
        Room = room;
    }
    public CannotDisconnectRoomFromSelfException(IRoom room, string message, Exception inner)
		: base(message, inner)
    {
        Room = room;
    }
}