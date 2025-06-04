using Game.Managers;

namespace Game;

public class Game
{
    public const string INPUT_COMMAND_MOVE = "move";
    public const string INPUT_COMMAND_ATTACK = "attack";
    public const string INPUT_COMMAND_PICKUP = "pickup";

    public GameState State
    {
        get;
        set
        {
            field = value;
            _gameManager.State = value;
            _saveManager.State = value;
        }
    }

    private readonly GameManager _gameManager;
    private readonly SaveManager _saveManager;

    public Game()
    {
        State = new();
        _gameManager = new(State);
        _saveManager = new(State);
    }

    public void Save(string path)
    {
        _saveManager.Save(path);
    }

    public void Load(string path)
    {
        _saveManager.Load(path);
    }

    public void Start()
    {
        _gameManager.Start();
    }

    public void Process(string input)
    {
        _gameManager.Process(input);
    }
}
