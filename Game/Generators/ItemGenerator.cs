using Items;

namespace Game.Generators;

public static class ItemGenerator
{
    private static readonly Random _radonom = new();

    public static List<Item> GeneratePlayerStartingItems()
    {
        List<Potion> potions = [
                new Potion
                {
                    Name = "Potion",
                    MaxHealth = 20,
                    Health = 20,
                },
                new Potion
                {
                    Name = "Potion",
                    MaxHealth = 20,
                    Health = 20,
                },
                new Potion
                {
                    Name = "Potion",
                    MaxHealth = 20,
                    Health = 20,
                },
            ];

        Weapon weapon = GenerateWeapon("SWeapon");
        Armor armor = GenerateArmor("SArmor");

        return [weapon, armor, .. potions];
    }

    public static Weapon GenerateWeapon(string? name = null)
    {
        return new Weapon
        {
            Name = name
        };
    }

    public static Armor GenerateArmor(string? name = null)
    {
        return new Armor
        {
            Name = name
        };
    }

    public static Potion GeneratePotion()
    {
        return new();
    }
}
