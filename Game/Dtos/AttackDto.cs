using Core.Structs;

namespace Game.Dtos;

public class AttackDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public AttackRoll? AttackRoll { get; set; }
    public DamageRoll? DamageRoll { get; set; }
}
