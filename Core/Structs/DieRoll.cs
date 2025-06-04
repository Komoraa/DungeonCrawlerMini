namespace Core.Structs;

public struct DieRoll
{
    public IDie Die { get; set; }
    public int Amount { get; set; }
    public int Result { get; private set; }

    public DieRoll(IDie die, int amount)
    {
        Die = die;
        Amount = amount;
        Roll();
    }

    public override string ToString()
    {
        return $"{Amount}{Die.DieSize}";
    }
    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        return ToString().Equals(obj?.ToString());
    }

    public void Roll()
    {
        int result = 0;
        for (int i = 0; i < Amount; i++)
        {
            result += Die.Roll();
        }
        Result = result;
    }

    public static bool operator ==(DieRoll left, DieRoll right)
    {
        return left.Equals(right);
    }
    public static bool operator !=(DieRoll left, DieRoll right)
    {
        return !(left == right);
    }
}
