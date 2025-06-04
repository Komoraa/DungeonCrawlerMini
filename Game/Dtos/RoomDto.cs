namespace Game.Dtos;

public class RoomDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<ItemDto> Items { get; set; } = [];
    public List<CharacterDto> Enemies { get; set; } = [];
}
