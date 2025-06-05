using Actions;
using Game.Dtos;
using Items;

namespace Game.Mappers;

public static class WeaponMapper
{
    public static WeaponDto ToDto(this Weapon weapon)
    {
        return new WeaponDto
        {
            Id = weapon.Id,
            Name = weapon.Name,
            Description = weapon.Description,
            Value = weapon.Value.ToDto(),
            Attacks = [.. from attack in weapon.Attacks select ((Attack)attack).ToDto()],
        };
    }

    public static Weapon ToEntity(this WeaponDto dto)
    {
        var weapon = new Weapon
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            Value = dto.Value!.ToEntity(),
        };

        foreach (var attack in dto.Attacks) weapon.TryAdd(attack.ToEntity());

        return weapon;
    }
}
