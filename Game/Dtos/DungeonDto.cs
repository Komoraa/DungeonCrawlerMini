namespace Game.Dtos;

public class DungeonDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<RoomDto> Rooms { get; set; } = [];
    public Dictionary<Guid, List<Guid>> ConnectionMap { get; set; } = [];
}
