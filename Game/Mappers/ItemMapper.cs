using Game.Dtos;
using Items;

namespace Game.Mappers;

public static class ItemMapper
{
    public static ItemDto ToDto(this Item item)
    {
        return new ItemDto
        {
            Id = item.Id,
            Name = item.Name,
            Description = item.Description,
            Value = item.Value,
        };
    }

    public static Item ToEntity(this ItemDto dto)
    {
        return new Item
        {
            Id = dto.Id,
            Name = dto.Name!,
            Description = dto.Description!,
            Value = dto.Value,
        };
    }
}
