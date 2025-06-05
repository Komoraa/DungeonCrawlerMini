using Core;
using Core.Structs;

namespace Actions;

public class Attack : IAttack
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name
    {
        get;
        set
        {
            field = value ?? nameof(Attack);
        }
    } = nameof(Attack);

    public string? Description
    {
        get;
        set
        {
            field = value ?? nameof(Attack);
        }
    } = nameof(Attack);

    public AttackRoll? AttackRoll { get; set; }

    public DamageRoll? DamageRoll { get; set; }

    public Attack(string? name = null, string? description = null, AttackRoll? attackRoll = null, DamageRoll? damageRoll = null)
    {
        Name = name;
        Description = description;
        AttackRoll = attackRoll;
        DamageRoll = damageRoll;
        Roll();
    }

    public void Roll()
    {
        if (AttackRoll is not null)
        {
            foreach(var dieRoll in AttackRoll?.DieRolls ?? [])
            {
                dieRoll.Roll();
            }
        }
        if (DamageRoll is not null)
        {
            foreach (var dieRoll in DamageRoll?.DieRolls ?? [])
            {
                dieRoll.Roll();
            }
        }
    }
}
