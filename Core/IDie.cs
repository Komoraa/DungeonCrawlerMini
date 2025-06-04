using Core.Enums;

namespace Core;

public interface IDie
{
    DieSize DieSize { get; init; }

    int MaxValue { get; }

    int Roll();
}
