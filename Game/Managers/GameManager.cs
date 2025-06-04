using Game.Generators;

namespace Game.Managers;

internal class GameManager
{
    internal GameState State { get; set; }

    private readonly CharacterGenerator _characterGenerator;
    private readonly DungeonGenerator _dungeonGenerator;
    private readonly RoomGenerator _roomGenerator;

    public GameManager(GameState state)
    {
        State = state;

        _characterGenerator = new();
        _dungeonGenerator = new();
        _roomGenerator = new();
    }

    public void Start()
    {

    }

    public void Process(string input)
    {

    }
}
