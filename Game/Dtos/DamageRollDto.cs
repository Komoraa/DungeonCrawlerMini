namespace Game.Dtos;

public struct DamageRollDto
{
    public int Base { get; set; }
    public List<DieRollDto> DieRolls { get; set; }
}
