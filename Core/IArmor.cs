namespace Core;

public interface IArmor : IItem
{
    int ArmorClass { get; }
    int SpeedAdjustment { get; }
    int? DexterityCap { get; }
}
