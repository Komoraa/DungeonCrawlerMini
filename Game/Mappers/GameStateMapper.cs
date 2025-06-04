using Dungeons;
using Game.Dtos;

namespace Game.Mappers;

public static class GameStateMapper
{
    public static GameStateDto ToDto(this GameState state)
    {
        return new GameStateDto
        {
            Player = state.Player!.ToDto(),
            Dungeon = state.Dungeon!.ToDto(),
            CurrentRoom = state.CurrentRoom!.Id,
            VisitedRooms = [.. from room in state.VisitedRooms select room.Id]
        };
    }

    public static GameState ToEntity(this GameStateDto dto)
    {
        var state = new GameState
        {
            Player = dto.Player!.ToEntity(),
            Dungeon = dto.Dungeon!.ToEntity(),
        };

        state.CurrentRoom = (Room)(from room in state.Dungeon.Rooms where room.Id == dto.CurrentRoom select room).First();

        foreach (var room in dto.VisitedRooms)
        {
            
        }

        return state;
    }
}
