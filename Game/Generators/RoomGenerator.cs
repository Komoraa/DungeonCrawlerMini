using Dungeons;

namespace Game.Generators;

public static class RoomGenerator
{
    private static readonly string[] Adjectives = [
        "Dusty", "Dark", "Ancient", "Silent", "Hidden", "Golden", "Cursed", "Frozen", "Forgotten", "Twisting"
    ];

    private static readonly string[] Nouns = [
        "Chamber", "Sanctum", "Corridor", "Hall", "Vault", "Cellar", "Keep", "Lair", "Passage", "Gallery"
    ];

    private static readonly Random random = new();

    private static string GetRandomName()
    {
        return $"{Adjectives[random.Next(Adjectives.Length)]} {Nouns[random.Next(Nouns.Length)]}";
    }

    public static Room GenerateRoom()
    {
        var room = new Room
        {
            Name = GetRandomName(),
        };

        for (int i = 0; i < random.Next(4); i++)
        {
            if (random.NextDouble() < 0.3)
            {
                room.TryAdd(ItemGenerator.GeneratePotion());
            }
            else if (random.NextDouble() < 0.6)
            {
                room.TryAdd(ItemGenerator.GenerateWeapon());
            }
            else
            {
                room.TryAdd(ItemGenerator.GenerateArmor());
            }
        }

        for (int i = 0; i < random.Next(3); i++)
        {
            room.TryAdd(CharacterGenerator.GenerateEnemy());
        }

        return room;
    }
}
