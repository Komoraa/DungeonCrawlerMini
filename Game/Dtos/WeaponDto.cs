using Core;

namespace Game.Dtos;

public class WeaponDto : ItemDto
{
    public List<IAttack> Attacks { get; set; } = [];
}
