using Items;

namespace Game.Generators;

public static class ItemGenerator
{
    public static Item GenerateItem()
    {
        return new();
    }

    public static Weapon GenerateWeapon()
    {
        return new();
    }

    public static Armor GenerateArmor()
    {
        return new();
    }
}
