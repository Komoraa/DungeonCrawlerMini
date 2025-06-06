using Core.Structs;

namespace Core;

public interface IAttack
{
    Guid Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }

    AttackRoll? AttackRoll { get; set; }
    DamageRoll? DamageRoll { get; set; }

    void Roll();
}
