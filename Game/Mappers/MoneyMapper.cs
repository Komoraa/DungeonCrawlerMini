using Core.Structs;
using Game.Dtos;

namespace Game.Mappers;

public static class MoneyMapper
{
    public static MoneyDto ToDto(this Money money)
    {
        return new MoneyDto
        {
            Platinum = money.Platinum,
            Gold = money.Gold,
            Silver = money.Silver,
            Copper = money.Copper,
        };
    }

    public static Money ToEntity(this MoneyDto dto)
    {
        return new Money(dto.Platinum, dto.Gold, dto.Silver, dto.Copper);
    }
}
