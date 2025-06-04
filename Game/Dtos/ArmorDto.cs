namespace Game.Dtos;

public class ArmorDto : ItemDto
{
    public int ArmorClass { get; set; }
    public int SpeedAdjustment { get; set; }
    public int? DexterityCap { get; set; }
}
