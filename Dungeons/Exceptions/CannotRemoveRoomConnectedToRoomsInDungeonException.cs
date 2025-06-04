using Core;

namespace Dungeons.Exceptions;


[Serializable]
public class CannotRemoveRoomConnectedToRoomsInDungeonException : Exception
{
	public IDungeon Dungeon { get; }
	public IRoom Room { get; }

	public CannotRemoveRoomConnectedToRoomsInDungeonException(IDungeon dungeon, IRoom room)
	{
		Dungeon = dungeon;
		Room = room;
	}
	public CannotRemoveRoomConnectedToRoomsInDungeonException(IDungeon dungeon, IRoom room, string message)
		: base(message)
    {
        Dungeon = dungeon;
        Room = room;
    }
    public CannotRemoveRoomConnectedToRoomsInDungeonException(IDungeon dungeon, IRoom room, string message, Exception inner)
		: base(message, inner)
    {
        Dungeon = dungeon;
        Room = room;
    }
}
