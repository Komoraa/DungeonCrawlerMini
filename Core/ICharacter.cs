using Core.Structs;

namespace Core;

public interface ICharacter
{
    Guid Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }

    int Level { get; set; }
    int Experience { get; set; }

    int Strength { get; set; }
    int Dexterity { get; set; }
    int Intelligence { get; set; }
    int Perception { get; set; }

    int MaxHealth { get; }
    int Health { get; set; }
    bool IsConscious { get; }

    IReadOnlyList<IItem> Inventory { get; }
    Money Money { get; set; }

    IReadOnlyList<IAttack> InnateAttacks { get; }
    IReadOnlyList<IAttack> Attacks { get; }
    IWeapon? Weapon { get; set; }
    IArmor? Armor { get; set; }
    int ArmorClass { get; }
    int Speed { get; set; }

    void LevelUp();
    void GrantExperience(int amount);

    bool ShouldTakeDamage(AttackRoll? attackRoll = null);
    void TakeDamage(DamageRoll? damageRoll = null);

    bool Has(IItem item);
    void PickUp(IItem item);
    bool TryPickUp(IItem item);
    void Drop(IItem item);
    bool TryDrop(IItem item);
    void Equip(IItem item);
    bool TryEquip(IItem item);
    void Unequip(IItem item);
    bool TryUnequip(IItem item);
    void Use(IItem item);
    bool TryUse(IItem item);

    bool Has(IAttack attack);
    bool HasInnate(IAttack attack);
    void AddInnate(IAttack attack);
    bool TryAddInnate(IAttack attack);
    void RemoveInnate(IAttack attack);
    bool TryRemoveInnate(IAttack attack);
    void Attack(IAttack attack, params Span<ICharacter> targets);
    bool TryAttack(IAttack attack, params Span<ICharacter> targets);
}
