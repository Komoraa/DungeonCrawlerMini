using Game.Dtos;
using Items;

namespace Game.Mappers;

public static class ArmorMapper
{
    public static ArmorDto ToDto(this Armor armor)
    {
        return new ArmorDto
        {
            Id = armor.Id,
            Name = armor.Name,
            Description = armor.Description,
            Value = armor.Value,
            ArmorClass = armor.ArmorClass,
            SpeedAdjustment = armor.SpeedAdjustment,
            DexterityCap = armor.DexterityCap,
        };
    }

    public static Armor ToEntity(this ArmorDto dto)
    {
        return new Armor
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            Value = dto.Value,
            ArmorClass = dto.ArmorClass,
            SpeedAdjustment = dto.SpeedAdjustment,
            DexterityCap = dto.DexterityCap,
        };
    }
}
