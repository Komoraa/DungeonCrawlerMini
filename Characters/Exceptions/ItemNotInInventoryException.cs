using Core;

namespace Characters.Exceptions;


[Serializable]
public class ItemNotInInventoryException : Exception
{
    public ICharacter Character { get; }
    public IItem Item { get; }

    public ItemNotInInventoryException(ICharacter character, IItem item)
    {
        Character = character;
        Item = item;
    }
    public ItemNotInInventoryException(ICharacter character, IItem item, string message)
        : base(message)
    {
        Character = character;
        Item = item;
    }
    public ItemNotInInventoryException(ICharacter character, IItem item, string message, Exception inner)
        : base(message, inner)
    {
        Character = character;
        Item = item;
    }
}
