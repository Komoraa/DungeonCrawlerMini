namespace Core;

public interface IPotion : IItem
{
    public int MaxHealth { get; set; }
    public int Health { get; set; }
}
