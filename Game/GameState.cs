using Characters;
using Dungeons;

namespace Game;

public class GameState
{
    public Character? Player { get; set; }
    public Dungeon? Dungeon { get; set; }
    public Room? CurrentRoom { get; set; }
}
