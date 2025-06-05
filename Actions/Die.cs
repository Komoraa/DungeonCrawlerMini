using Core.Enums;

namespace Core;

public class Die(DieSize dieSize) : IDie
{
    private readonly Random _random = new();

    public DieSize DieSize { get; init; } = dieSize;

    public int MaxValue
    {
        get
        {
            return (int)DieSize;
        }
    }

    public int Roll()
    {
        return _random.Next((int)DieSize + 1);
    }
}
