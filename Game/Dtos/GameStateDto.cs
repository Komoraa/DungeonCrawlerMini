namespace Game.Dtos;

public class GameStateDto
{
    public CharacterDto? Player { get; set; }
    public DungeonDto? Dungeon { get; set; }
    public List<Guid> VisitedRooms { get; set; } = [];
    public Guid CurrentRoom { get; set; }
}
