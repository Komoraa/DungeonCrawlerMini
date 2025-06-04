using Core;

namespace Dungeons.Exceptions;


[Serializable]
public class CannotConnectRoomToSelfException : Exception
{
	public IRoom Room { get; }

	public CannotConnectRoomToSelfException(IRoom room)
	{
		Room = room;
	}
	public CannotConnectRoomToSelfException(IRoom room, string message)
		: base(message)
    {
        Room = room;
    }
    public CannotConnectRoomToSelfException(IRoom room, string message, Exception inner)
		: base(message, inner)
    {
        Room = room;
    }
}
