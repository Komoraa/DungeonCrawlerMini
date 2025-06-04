using Core.Structs;

namespace Game.Dtos;

public class ItemDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Money Value { get; set; }
}
