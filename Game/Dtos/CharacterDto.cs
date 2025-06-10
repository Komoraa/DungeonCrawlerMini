namespace Game.Dtos;

public class CharacterDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public int Level { get; set; }
    public int Experience { get; set; }

    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Perception { get; set; }

    public int MaxHealthBase { get; set; }
    public int MaxHealthPerLevel { get; set; }
    public int Health { get; set; }

    public List<WeaponDto> InventoryWeapons { get; set; } = [];
    public List<ArmorDto> InventoryArmors { get; set; } = [];
    public List<PotionDto> InventoryPotions { get; set; } = [];
    public List<ItemDto> InventoryOther { get; set; } = [];
    public MoneyDto Money { get; set; }

    public List<AttackDto> InnateAttacks { get; set; } = [];
    
    public WeaponDto? Weapon { get; set; }
    public ArmorDto? Armor { get; set; }
}
