using Core.Structs;

namespace Core;

public interface IItem
{
    Guid Id { get; }
    string? Name { get; }
    string? Description { get; }

    Money Value { get; }
}
