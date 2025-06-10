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
            MaxHealth = character.MaxHealth,
            Health = character.Health,
            InventoryWeapons = [.. from item in character.Inventory
                                   where item is Weapon
                                   select ((Weapon)item).ToDto()],
            InventoryArmors = [.. from item in character.Inventory
                                  where item is Armor
                                  select ((Armor)item).ToDto()],
            InventoryPotions = [.. from item in character.Inventory
                                   where item is Potion
                                   select ((Potion)item).ToDto()],
            InventoryOther = [.. from item in character.Inventory
                                 where item is not Weapon && item is not Armor && item is not Potion
                                 select ((Item)item).ToDto()],
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
            MaxHealth = dto.MaxHealth,
            Health = dto.Health,
            Money = dto.Money.ToEntity(),
            Weapon = dto.Weapon?.ToEntity(),
            Armor = dto.Armor?.ToEntity()
        };

        foreach (var item in dto.InventoryWeapons) character.TryPickUp(item.ToEntity());
        foreach (var item in dto.InventoryArmors) character.TryPickUp(item.ToEntity());
        foreach (var item in dto.InventoryPotions) character.TryPickUp(item.ToEntity());
        foreach (var item in dto.InventoryOther) character.TryPickUp(item.ToEntity());

        foreach (var attack in dto.InnateAttacks) character.TryAddInnate(attack.ToEntity());

        return character;
    }
}
