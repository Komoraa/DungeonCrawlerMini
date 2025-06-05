using Dungeons;
using Game.Generators;

namespace Game;

public class GameManager
{
    public const string INPUT_COMMAND_MOVE = "move";
    public const string INPUT_COMMAND_ATTACK = "attack";
    public const string INPUT_COMMAND_PICKUP = "pickup";

    public GameState State { get; set; } = new();

    public void Start()
    {
        State.Player ??= CharacterGenerator.GeneratePlayer();
        State.Dungeon ??= DungeonGenerator.GenerateDungeon();
        State.CurrentRoom ??= (Room)State.Dungeon.Rooms[0];
        State.VisitedRooms.Add(State.CurrentRoom);
    }

    public void Process(string input)
    {

    }

    public void MoveTo(Room room)
    {
        
    }
}
