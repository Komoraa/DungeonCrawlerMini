using Core;
using Core.Structs;

namespace Items
{
    public class Item : IItem
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
            return $"{Name}, Worth: {Value}, Description: {Description}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return ToString().Equals(obj?.ToString());
        }
    }
}
