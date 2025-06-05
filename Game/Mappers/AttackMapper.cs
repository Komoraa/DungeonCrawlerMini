using Actions;
using Game.Dtos;

namespace Game.Mappers;

public static class AttackMapper
{
    public static AttackDto ToDto(this Attack attack)
    {
        return new AttackDto
        {
            Id = attack.Id,
            Name = attack.Name,
            Description = attack.Description,
            AttackRoll = attack.AttackRoll?.ToDto(),
            DamageRoll = attack.DamageRoll?.ToDto(),
        };
    }

    public static Attack ToEntity(this AttackDto dto)
    {
        return new Attack
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            AttackRoll = dto.AttackRoll?.ToEntity(),
            DamageRoll = dto.DamageRoll?.ToEntity(),
        };
    }
}
