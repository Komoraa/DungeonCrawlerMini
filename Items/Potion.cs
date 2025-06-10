using Core;

namespace Items;

public class Potion : Item, IPotion
{
    public int MaxHealth
    {
        get;
        set
        {
            field = Math.Max(value, 0);
        }
    }
    public int Health
    {
        get;
        set
        {
            field = Math.Max(0, value);
        }
    }

    public override string ToString()
    {
        return $"Potion named {Name} worth {Value}";
    }
}
