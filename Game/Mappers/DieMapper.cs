using Core.Structs;
using Game.Dtos;

namespace Game.Mappers;

public static class DieMapper
{
    public static DieDto ToDto(this Die die)
    {
        return new DieDto
        {
            DieSize = die.DieSize
        };
    }

    public static Die ToEntity(this DieDto dto)
    {
        return new Die
        {
            DieSize = dto.DieSize
        };
    }
}
