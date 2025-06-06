namespace Core;

public interface IArmor : IItem
{
    int ArmorClass { get; set; }
    int SpeedAdjustment { get; set; }
    int? DexterityCap { get; set; }
}
