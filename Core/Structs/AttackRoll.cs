namespace Core.Structs;

public struct AttackRoll
{
    public int Base { get; set; }
    public int Rolled { get; private set; }
    public readonly int Result => Base + Rolled;

    public List<DieRoll> DieRolls { get; } = [];

    public AttackRoll(int baseAttack = 0, params Span<DieRoll> dieRolls)
    {
        Base = baseAttack;
        DieRolls.AddRange(dieRolls);
        Roll();
    }

    public override readonly string ToString()
    {
        var rolls = from roll in DieRolls
                    orderby roll.Die.DieSize ascending, roll.Amount descending
                    select $"{roll.Result} ({roll})";

        return $"{Base} + [{string.Join(", ", DieRolls)}]";
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

    public static bool operator ==(AttackRoll left, AttackRoll right)
    {
        return left.Result == right.Result;
    }
    public static bool operator !=(AttackRoll left, AttackRoll right)
    {
        return !(left == right);
    }
}
