namespace Core;

public interface IPotion : IItem
{
    public int HealthGain { get; set; }
}
