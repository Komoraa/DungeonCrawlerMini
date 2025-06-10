namespace Game.Dtos;

public class RoomDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool Visited { get; set; }
    public List<WeaponDto> ItemsWeapons { get; set; } = [];
    public List<ArmorDto> ItemsArmors { get; set; } = [];
    public List<PotionDto> ItemsPotions { get; set; } = [];
    public List<ItemDto> ItemsOther { get; set; } = [];
    public List<CharacterDto> Enemies { get; set; } = [];
}
