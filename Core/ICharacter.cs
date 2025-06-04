using Core.Structs;

namespace Core;

public interface ICharacter
{
    Guid Id { get; }
    string? Name { get; }
    string? Description { get; }

    int Level { get; }
    int Experience { get; }

    int Strength { get; }
    int Dexterity { get; }
    int Intelligence { get; }
    int Perception { get; }

    int MaxHealth { get; }
    int Health { get; }
    bool IsConscious { get; }

    IReadOnlyList<IItem> Inventory { get; }
    Money Money { get; }

    IReadOnlyList<IAttack> InnateAttacks { get; }
    IReadOnlyList<IAttack> Attacks { get; }
    IWeapon? Weapon { get; }
    IArmor? Armor { get; }
    int ArmorClass { get; }
    int Speed { get; }

    void Init();

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

    bool Has(IAttack attack);
    bool HasInnate(IAttack attack);
    void AddInnate(IAttack attack);
    bool TryAddInnate(IAttack attack);
    void RemoveInnate(IAttack attack);
    bool TryRemoveInnate(IAttack attack);
    void Attack(IAttack attack, params Span<ICharacter> targets);
    bool TryAttack(IAttack attack, params Span<ICharacter> targets);
}
