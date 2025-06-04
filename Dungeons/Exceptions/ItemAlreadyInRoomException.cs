using Core;

namespace Dungeons.Exceptions;


[Serializable]
public class ItemAlreadyInRoomException : Exception
{
	public IRoom Room { get; }
	public IItem Item { get; }

	public ItemAlreadyInRoomException(IRoom room, IItem item)
	{
		Room = room;
		Item = item;
	}
	public ItemAlreadyInRoomException(IRoom room, IItem item, string message)
		: base(message)
    {
        Room = room;
        Item = item;
    }
    public ItemAlreadyInRoomException(IRoom room, IItem item, string message, Exception inner)
		: base(message, inner)
    {
        Room = room;
        Item = item;
    }
}
