using Dungeons;
using Game.Generators;

namespace Game;

public class GameManager
{
    public GameState State { get; set; }

    public GameManager(GameState? state = null)
    {
        State = state ?? new();
        if (State.Player is null) State.Player = CharacterGenerator.GeneratePlayer();
        if (State.Dungeon is null)
        {
            State.Dungeon = DungeonGenerator.GenerateDungeon();
            State.CurrentRoom = (Room)State.Dungeon.Rooms[0];
            State.VisitedRooms.Add(State.CurrentRoom);
        }
    }
}
