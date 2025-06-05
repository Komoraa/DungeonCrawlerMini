namespace Game.Dtos;

public class WeaponDto : ItemDto
{
    public List<AttackDto> Attacks { get; set; } = [];
}
