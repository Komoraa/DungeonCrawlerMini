using Core;
using Core.Structs;

namespace Items
{
    public class Item : IItem, IEquatable<Item>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name
        {
            get;
            set
            {
                field = value ?? nameof(Item);
            }
        } = nameof(Item);

        public string? Description
        {
            get;
            set
            {
                field = value ?? nameof(Item);
            }
        } = nameof(Item);

        public Money Value { get; set; } = Money.Zero;

        public override string ToString()
        {
            return $"Item named {Name} worth {Value}";
        }

        public bool Equals(Item? other)
        {
            return Id == other?.Id;
        }
        public static bool operator ==(Item left, Item right)
        {
            return left.Id == right.Id;
        }
        public static bool operator !=(Item left, Item right)
        {
            return left.Id != right.Id;
        }
    }
}
