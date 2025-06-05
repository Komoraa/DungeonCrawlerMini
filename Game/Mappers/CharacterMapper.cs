using Actions;
using Characters;
using Game.Dtos;
using Items;

namespace Game.Mappers;

public static class CharacterMapper
{
    public static CharacterDto ToDto(this Character character)
    {
        var dto = new CharacterDto
        {
            Id = character.Id,
            Name = character.Name,
            Description = character.Description,
            Level = character.Level,
            Experience = character.Experience,
            Strength = character.Strength,
            Dexterity = character.Dexterity,
            Intelligence = character.Intelligence,
            Perception = character.Perception,
            MaxHealthBase = character.MaxHealthBase,
            MaxHealthPerLevel = character.MaxHealthPerLevel,
            MaxHealth = character.MaxHealth,
            Health = character.Health,
            Inventory = [.. from item in character.Inventory select ((Item)item).ToDto()],
            Money = character.Money.ToDto(),
            InnateAttacks = [.. from attack in character.InnateAttacks select ((Attack)attack).ToDto()]
        };

        if (character.Weapon is not null) dto.Weapon = ((Weapon)character.Weapon).ToDto();
        if (character.Armor is not null) dto.Armor = ((Armor)character.Armor).ToDto();

        return dto;
    }

    public static Character ToEntity(this CharacterDto dto)
    {
        var character = new Character
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            Level = dto.Level,
            Experience = dto.Experience,
            Strength = dto.Strength,
            Dexterity = dto.Dexterity,
            Intelligence = dto.Intelligence,
            Perception = dto.Perception,
            MaxHealthBase = dto.MaxHealthBase,
            MaxHealthPerLevel = dto.MaxHealthPerLevel,
            MaxHealth = dto.MaxHealth,
            Health = dto.Health,
            Money = dto.Money.ToEntity(),
        };

        if (dto.Weapon is not null) character.Weapon = dto.Weapon.ToEntity();
        if (dto.Armor is not null) character.Armor = dto.Armor.ToEntity();

        foreach (var item in dto.Inventory) character.TryPickUp(item.ToEntity());
        foreach (var attack in dto.InnateAttacks) character.TryAddInnate(attack.ToEntity());

        return character;
    }
}
