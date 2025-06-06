using Core.Structs;

namespace Core;

public interface IItem
{
    Guid Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }
    Money Value { get; set; }
}
