using Actions;
using Core.Enums;
using Core.Structs;

namespace Game.Generators;

public static class ActionGenerator
{
    private static readonly Random _random = new();
    private static readonly DieSize[] _damageDieSizes = [DieSize.D6, DieSize.D8, DieSize.D10, DieSize.D12];

    private static readonly Die _d4 = new(DieSize.D4);
    private static readonly Die _d6 = new(DieSize.D6);
    private static readonly Die _d8 = new(DieSize.D8);
    private static readonly Die _d10 = new(DieSize.D10);
    private static readonly Die _d12 = new(DieSize.D12);
    private static readonly Die _d20 = new(DieSize.D20);

    public static List<Attack> GenerateInnatePlayer()
    {
        var fistAttack = new Attack
        {
            Name = "Fists",
            AttackRoll = new AttackRoll(0, new DieRoll(_d20, 1)),
            DamageRoll = new DamageRoll(0, new DieRoll(_d6, 1))
        };
        var kickAttack = new Attack
        {
            Name = "Kick",
            AttackRoll = new AttackRoll(0, new DieRoll(_d20, 1)),
            DamageRoll = new DamageRoll(0, new DieRoll(_d8, 1))
        };
        return [fistAttack, kickAttack];
    }

    public static List<Attack> GenerateInnateEnemy(params string[] names)
    {
        var fistAttack = new Attack
        {
            Name = "Fists",
            AttackRoll = new AttackRoll(0, new DieRoll(_d20, 1)),
            DamageRoll = new DamageRoll(0, new DieRoll(_d4, 1))
        };
        var kickAttack = new Attack
        {
            Name = "Kick",
            AttackRoll = new AttackRoll(0, new DieRoll(_d20, 1)),
            DamageRoll = new DamageRoll(0, new DieRoll(_d6, 1))
        };
        return [fistAttack, kickAttack];
    }

    private static DieRoll[] GenerateDamageDiceSet(int minTotal = 8, int maxTotal = 24)
    {
        List<DieRoll> rolls = [];
        int totalMax = 0;

        while (totalMax < minTotal || (totalMax < maxTotal && _random.NextDouble() >= 0.7))
        {
            var dieSize = _damageDieSizes[_random.Next(_damageDieSizes.Length)];
            var die = new Die(dieSize);
            int amount = _random.Next(1, 4); // 1–3 dice
            int rollMax = (int)dieSize * amount;

            if (totalMax + rollMax > maxTotal) continue;

            var roll = new DieRoll(die, amount);
            rolls.Add(roll);
            totalMax += roll.MaxValue;
        }

        return [.. rolls];
    }

    public static List<Attack> GenerateWeapon(params string[] names)
    {
        List<Attack> attacks = [];
        foreach (var name in names)
        {
            var attackRoll = new AttackRoll(0, new DieRoll(_d20, 1));
            var damageRoll = new DamageRoll(
                baseDamage: _random.Next(0, 4),
                GenerateDamageDiceSet()
            );
            var attack = new Attack
            {
                Name = name,
                AttackRoll = attackRoll,
                DamageRoll = damageRoll
            };
            attacks.Add(attack);
        }
        return attacks;
    }
}
