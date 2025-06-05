using Core.Structs;

namespace Core;

public interface IAttack
{
    Guid Id { get; }
    string? Name { get; }
    string? Description { get; }

    AttackRoll? AttackRoll { get; }
    DamageRoll? DamageRoll { get; }

    void Roll();
}
