using Core;

namespace Dungeons.Exceptions;


[Serializable]
public class RoomNotConnectedToRoomException : Exception
{
    public IDungeon Dungeon { get; }
    public IRoom Origin { get; }
    public IRoom Destination { get; }

    public RoomNotConnectedToRoomException(IDungeon dungeon, IRoom origin, IRoom destination)
    {
        Dungeon = dungeon; 
        Origin = origin;
        Destination = destination;
    }
    public RoomNotConnectedToRoomException(IDungeon dungeon, IRoom origin, IRoom destination, string message)
        : base(message)
    {
        Dungeon = dungeon; 
        Origin = origin;
        Destination = destination;
    }
    public RoomNotConnectedToRoomException(IDungeon dungeon, IRoom origin, IRoom destination, string message, Exception inner)
        : base(message, inner)
    {
        Dungeon = dungeon;
        Origin = origin;
        Destination = destination;
    }
}
