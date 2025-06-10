using Characters;

namespace Game.Generators;

public static class CharacterGenerator
{
    public static Character GeneratePlayer()
    {
        var player = new Character
        {
            Name = "Player",

            Level = 1,
            Experience = 0,
            Strength = 12,
            Dexterity = 8,
            Intelligence = 8,
            Perception = 10,

            MaxHealth = 50,
            Health = 50,

            Money = new(0, 10, 5, 2),

            Speed = 25
        };

        foreach (var attack in ActionGenerator.GenerateInnatePlayer())
        {
            player.TryAddInnate(attack);
        }
        foreach (var item in ItemGenerator.GeneratePlayerStartingItems())
        {
            player.TryPickUp(item);
        }

        return player;
    }

    public static List<Character> GenerateEnemies(params string[] names)
    {
        List<Character> enemies = [];

        return enemies;
    }
}
