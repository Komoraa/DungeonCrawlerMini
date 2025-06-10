using Core.Structs;
using Game.Dtos;

namespace Game.Mappers;

public static class DieRollMapper
{
    public static DieRollDto ToDto(this DieRoll roll)
    {
        return new DieRollDto
        {
            Die = roll.Die.ToDto(),
            Amount = roll.Amount
        };
    }

    public static DieRoll ToEntity(this DieRollDto dto)
    {
        var roll = new DieRoll
        {
            Die = dto.Die!.ToEntity(),
            Amount = dto.Amount
        };

        roll.Roll();

        return roll;
    }
}
