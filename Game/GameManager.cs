using Dungeons;
using Game.Generators;

namespace Game;

public class GameManager
{
    public GameState State { get; set; } = new();

    public void Start()
    {
        State.Player ??= CharacterGenerator.GeneratePlayer();
        State.Dungeon ??= DungeonGenerator.GenerateDungeon();
        State.CurrentRoom ??= (Room)State.Dungeon.Rooms[0];
        State.VisitedRooms.Add(State.CurrentRoom);
    }
}
