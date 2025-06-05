using Core.Structs;
using Game.Dtos;

namespace Game.Mappers;

public static class DamageRollMapper
{
    public static DamageRollDto ToDto(this DamageRoll roll)
    {
        return new DamageRollDto
        {
            Base = roll.Base,
            DieRolls = [.. from dieRoll in roll.DieRolls select dieRoll.ToDto()],
        };
    }

    public static DamageRoll ToEntity(this DamageRollDto dto)
    {
        var roll = new DamageRoll(dto.Base, [.. from dieRoll in dto.DieRolls select dieRoll.ToEntity()]);

        roll.Roll();

        return roll;
    }
}
