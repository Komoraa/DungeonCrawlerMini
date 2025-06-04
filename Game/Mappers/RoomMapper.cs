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
            Enemies = [.. from enemy in room.Enemies select ((Character)enemy).ToDto()],
            Items = [.. from item in room.Items select ((Item)item).ToDto()]
        };
    }

    public static Room ToEntity(this RoomDto dto)
    {
        var room = new Room
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description
        };

        foreach (var enemy in dto.Enemies) room.TryAdd(enemy.ToEntity());
        foreach (var item in dto.Items) room.TryAdd(item.ToEntity());

        return room;
    }
}
