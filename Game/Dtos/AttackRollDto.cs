namespace Game.Dtos;

public struct AttackRollDto
{
    public int Base { get; set; }
    public List<DieRollDto> DieRolls { get; set; }
}
