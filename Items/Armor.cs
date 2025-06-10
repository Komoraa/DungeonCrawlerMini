using Core;

namespace Items;

public class Armor : Item, IArmor
{
    public int ArmorClass { get; set; }

    public int SpeedAdjustment { get; set; }

    public int? DexterityCap { get; set; }

    public override string ToString()
    {
        return $"Armor named {Name} worth {Value}";
    }
}
