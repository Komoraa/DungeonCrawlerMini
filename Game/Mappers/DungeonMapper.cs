using Dungeons;
using Game.Dtos;

namespace Game.Mappers;

public static class DungeonMapper
{
    public static DungeonDto ToDto(this Dungeon dungeon)
    {
        var dto = new DungeonDto
        {
            Id = dungeon.Id,
            Name = dungeon.Name,
            Description = dungeon.Description,
            Rooms = [.. from room in dungeon.Rooms select ((Room)room).ToDto()],
        };

        Dictionary<Guid, List<Guid>> connectionMap = [];
        foreach (var kvp in dungeon.ConnectionMap)
        {
            connectionMap[kvp.Key.Id] = [.. from room in kvp.Value select room.Id];
        }
        dto.ConnectionMap = connectionMap;

        return dto;
    }

    public static Dungeon ToEntity(this DungeonDto dto)
    {
        var dungeon = new Dungeon
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
        };

        foreach (var roomDto in dto.Rooms) dungeon.TryAdd(roomDto.ToEntity());

        foreach (var connection in dto.ConnectionMap)
        {
            var origin = (from room in dungeon.Rooms where room.Id == connection.Key select room).First();
            foreach (var roomId in connection.Value)
            {
                var destination = (from room in dungeon.Rooms where room.Id == roomId select room).First();
                dungeon.TryConnect(origin, destination, false);
            }
        }

        return dungeon;
    }
}
