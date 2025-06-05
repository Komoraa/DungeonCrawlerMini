namespace Game.Dtos;

public class AttackDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public AttackRollDto? AttackRoll { get; set; }
    public DamageRollDto? DamageRoll { get; set; }
}
