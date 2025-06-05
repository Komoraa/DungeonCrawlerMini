using Core.Structs;
using Game.Dtos;

namespace Game.Mappers;

public static class AttackRollMapper
{
    public static AttackRollDto ToDto(this AttackRoll roll)
    {
        return new AttackRollDto
        {
            Base = roll.Base,
            DieRolls = [.. from dieRoll in roll.DieRolls select dieRoll.ToDto()],
        };
    }

    public static AttackRoll ToEntity(this AttackRollDto dto)
    {
        var roll = new AttackRoll(dto.Base, [.. from dieRoll in dto.DieRolls select dieRoll.ToEntity()]);

        roll.Roll();

        return roll;
    }
}
