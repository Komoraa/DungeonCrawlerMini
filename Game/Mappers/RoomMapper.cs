using Characters;
using Dungeons;
using Game.Dtos;
using Items;

namespace Game.Mappers;

public static class RoomMapper
{
    public static RoomDto ToDto(this Room room)
    {
        return new RoomDto
        {
            Id = room.Id,
            Name = room.Name,
            Description = room.Description,
            Visited = room.Visited,
            Enemies = [.. from enemy in room.Enemies select ((Character)enemy).ToDto()],
            ItemsWeapons = [.. from item in room.Items
                               where item is Weapon
                               select ((Weapon)item).ToDto()],
            ItemsArmors = [.. from item in room.Items
                              where item is Armor
                              select ((Armor)item).ToDto()],
            ItemsPotions = [.. from item in room.Items
                               where item is Potion
                               select ((Potion)item).ToDto()],
            ItemsOther = [.. from item in room.Items
                             where item is not Weapon && item is not Armor && item is not Potion
                             select ((Item)item).ToDto()],
        };
    }

    public static Room ToEntity(this RoomDto dto)
    {
        var room = new Room
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            Visited = dto.Visited
        };

        foreach (var enemy in dto.Enemies) room.TryAdd(enemy.ToEntity());
        
        foreach (var item in dto.ItemsWeapons) room.TryAdd(item.ToEntity());
        foreach (var item in dto.ItemsArmors) room.TryAdd(item.ToEntity());
        foreach (var item in dto.ItemsPotions) room.TryAdd(item.ToEntity());
        foreach (var item in dto.ItemsOther) room.TryAdd(item.ToEntity());

        return room;
    }
}
