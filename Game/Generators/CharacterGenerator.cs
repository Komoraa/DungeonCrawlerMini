using Characters;

namespace Game.Generators;

public static class CharacterGenerator
{
    public static Character GeneratePlayer()
    {
        return new();
    }

    public static Character GenerateEnemy()
    {
        return new();
    }
}
