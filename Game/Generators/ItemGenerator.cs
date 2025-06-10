using Core.Structs;
using Items;

namespace Game.Generators;

public static class ItemGenerator
{
    private static readonly Random random = new();

    private static readonly string[] WeaponPrefixes = [
        "Flaming", "Shadow", "Iron", "Dragon", "Soul", "Thunder", "Venom", "Crimson", "Phantom", "Steel"
    ];

    private static readonly string[] WeaponTypes = [
        "Blade", "Axe", "Bow", "Spear", "Sword", "Dagger", "Hammer", "Mace", "Halberd", "Scythe"
    ];

    private static string GetRandomWeaponName()
    {
        if (random.NextDouble() < 0.3) // 30% chance to just use type alone
            return WeaponTypes[random.Next(WeaponTypes.Length)];
        return $"{WeaponPrefixes[random.Next(WeaponPrefixes.Length)]} {WeaponTypes[random.Next(WeaponTypes.Length)]}";
    }

    private static readonly string[] ArmorPrefixes = {
        "Sturdy", "Enchanted", "Worn", "Blessed", "Barbed", "Scorched",
        "Reinforced", "Silent", "Ghostly", "Obsidian", "Golden", "Ancient"
    };

    private static readonly string[] ArmorTypes = {
        "Helmet", "Breastplate", "Greaves", "Gauntlets", "Shield",
        "Cuirass", "Pauldrons", "Mail", "Coif", "Hauberk", "Bracers"
    };

    public static string GetRandomArmorName()
    {
        bool useModifier = random.NextDouble() < 0.75; // 75% chance to use a modifier
        string armor = ArmorTypes[random.Next(ArmorTypes.Length)];

        if (useModifier)
        {
            string modifier = ArmorPrefixes[random.Next(ArmorPrefixes.Length)];
            return $"{modifier} {armor}";
        }

        return armor;
    }

    public static Money GetRandomItemValue(int maxValue = 750)
    {
        return new Money(copper: random.Next(0, maxValue));
    }

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

        Weapon weapon = GenerateWeapon();
        Armor armor = GenerateArmor();

        return [weapon, armor, .. potions];
    }

    public static Weapon GenerateWeapon()
    {
        var attacks = ActionGenerator.GenerateWeapon("Swing 1", "Swing 2");

        var weapon = new Weapon
        {
            Name = GetRandomWeaponName(),
            Value = GetRandomItemValue()
        };

        foreach (var attack in attacks) weapon.TryAdd(attack);

        return weapon;
    }

    public static Armor GenerateArmor()
    {
        return new Armor
        {
            Name = GetRandomArmorName(),
            ArmorClass = random.Next(2, 8),
            Value = GetRandomItemValue()
        };
    }

    public static Potion GeneratePotion()
    {
        return new Potion
        {
            Name = "Healing Potion",
            MaxHealth = 40,
            Health = 40,
            Value = GetRandomItemValue()
        };
    }
}
