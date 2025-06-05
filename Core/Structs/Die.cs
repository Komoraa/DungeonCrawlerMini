using Core.Enums;

namespace Core.Structs;

public struct Die
{
    private readonly Random _random = new();
    public DieSize DieSize { get; set; }
    public readonly int MaxValue => (int)DieSize;

    public Die() { }
    public Die(DieSize dieSize)
    {
        DieSize = dieSize;
    }

    public readonly int Roll()
    {
        return _random.Next((int)DieSize + 1);
    }
}
