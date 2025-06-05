namespace Core.Structs;

public struct DamageRoll
{
    public int Base { get; set; }
    public int Rolled { get; private set; }
    public readonly int Result => Base + Rolled;

    public List<DieRoll> DieRolls { get; } = [];

    public DamageRoll(int baseDamage = 0, params Span<DieRoll> dieRolls)
    {
        Base = baseDamage;
        DieRolls.AddRange(dieRolls);
        Roll();
    }

    public override string ToString()
    {
        var rolls = from roll in DieRolls
                    orderby roll.Die.DieSize ascending, roll.Amount descending
                    select $"{roll.Result} ({roll})";

        return $"{Result} ({Base} Base + {Rolled} ({string.Join(" + ", rolls)})), Dice: [{string.Join(", ", DieRolls)}]";
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
        int rolled = 0;
        foreach (var dieRoll in DieRolls)
        {
            dieRoll.Roll();
            rolled += dieRoll.Result;
        }
        Rolled = rolled;
    }

    public static bool operator ==(DamageRoll left, DamageRoll right)
    {
        return left.Result == right.Result;
    }
    public static bool operator !=(DamageRoll left, DamageRoll right)
    {
        return !(left == right);
    }
}
