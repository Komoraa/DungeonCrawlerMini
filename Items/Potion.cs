using Core;

namespace Items;

public class Potion : Item, IPotion
{
    public int HealthGain
    {
        get;
        set
        {
            string empt = " (Empty)";
            field = Math.Max(0, value);
            if (field <= 0 && Name!.Contains(empt)) Name += empt;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"Health Gain: {HealthGain}";
    }
}
