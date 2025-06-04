namespace Core.Structs
{
    public readonly struct Money : IEquatable<Money>, IComparable, IComparable<Money>
    {
        public const int PlatinumToGold = 10;
        public const int GoldToSilver = 10;
        public const int SilverToCopper = 10;
        
        private readonly int _copperTotal;

        public int Platinum
        {
            get
            {
                return _copperTotal / (PlatinumToGold * GoldToSilver * SilverToCopper);
            }
        }
       
        public int Gold
        {
            get
            {
                return _copperTotal % (PlatinumToGold * GoldToSilver * SilverToCopper) / (GoldToSilver * SilverToCopper);
            }
        }
        
        public int Silver
        {
            get
            {
                return _copperTotal % (GoldToSilver * SilverToCopper) / SilverToCopper;
            }
        }
        
        public int Copper
        {
            get
            {
                return _copperTotal % SilverToCopper;
            }
        }

        public Money() { }
        
        public Money(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
        {
            _copperTotal = platinum * PlatinumToGold * GoldToSilver * SilverToCopper
                + gold * GoldToSilver * SilverToCopper
                + silver * SilverToCopper
                + copper;
        }

        public static readonly Money Zero = new();
        
        public static Money FromPlatinum(int platinum) => new(platinum: platinum);
        
        public static Money FromGold(int gold) => new(gold: gold);
        
        public static Money FromSilver(int silver) => new(silver: silver);
        
        public static Money FromCopper(int copper) => new(copper: copper);

        public override string ToString()
        {
            List<string> parts = [];
            if (Platinum > 0) parts.Add($"{Platinum} PP");
            if (Gold > 0) parts.Add($"{Gold} GP");
            if (Silver > 0) parts.Add($"{Silver} SP");
            if (Copper > 0 || parts.Count == 0) parts.Add($"{Copper} CP");
            return string.Join(" ", parts);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return ToString().Equals(obj?.ToString());
        }

        public bool Equals(Money other)
        {
            return _copperTotal == other._copperTotal;
        }

        public int CompareTo(object? obj)
        {
            return ToString().CompareTo(obj?.ToString());
        }

        public int CompareTo(Money other)
        {
            return _copperTotal.CompareTo(other._copperTotal);
        }

        public static Money operator +(Money left, Money right)
        {
            return new(left._copperTotal + right._copperTotal);
        }

        public static Money operator -(Money left, Money right)
        {
            return new(left.Copper - right._copperTotal);
        }

        public static bool operator ==(Money left, Money right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !(left == right);
        }
        public static bool operator <(Money left, Money right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Money left, Money right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(Money left, Money right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(Money left, Money right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
