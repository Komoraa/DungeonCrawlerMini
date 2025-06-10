using Game.Dtos;
using Items;

namespace Game.Mappers;

public static class PotionMapper
{
    public static PotionDto ToDto(this Potion potion)
    {
        return new PotionDto
        {
            Id = potion.Id,
            Name = potion.Name,
            Description = potion.Description,
            Value = potion.Value.ToDto(),
            MaxHealth = potion.MaxHealth,
            Health = potion.Health
        };
    }

    public static Potion ToEntity(this PotionDto dto)
    {
        return new Potion
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            Value = dto.Value.ToEntity(),
            MaxHealth = dto.MaxHealth,
            Health = dto.Health
        };
    }
}
