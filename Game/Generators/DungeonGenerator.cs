using Dungeons;

namespace Game.Generators;

public static class DungeonGenerator
{
    public static Dungeon GenerateDungeon(int roomCountMin = 10, int roomCountMax = 30, double extraConnectionChance = 0.3)
    {
        var random = new Random();
        int maxConnections = 5;
        int roomCount = random.Next(roomCountMin, roomCountMax + 1);
        var dungeon = new Dungeon();

        for (int i = 0; i < roomCount; i++) dungeon.TryAdd(RoomGenerator.GenerateRoom());

        var shuffled = (from room in dungeon.Rooms orderby random.Next() select room).ToList();

        for (int i = 0; i < shuffled.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (dungeon.ConnectionMap[shuffled[i]].Count < maxConnections &&
                    dungeon.ConnectionMap[shuffled[j]].Count < maxConnections)
                {
                    dungeon.TryConnect(shuffled[i], shuffled[j]);
                    break;
                }
            }
        }

        for (int i = 0; i < roomCount; i++)
        {
            for (int j = i + 1; j < roomCount; j++)
            {
                var a = dungeon.Rooms[i];
                var b = dungeon.Rooms[j];
                if (a != b &&
                    dungeon.ConnectionMap[a].Count < maxConnections &&
                    dungeon.ConnectionMap[b].Count < maxConnections &&
                    !dungeon.ConnectionMap[a].Contains(b) &&
                    !dungeon.ConnectionMap[b].Contains(a) &&
                    random.NextDouble() < extraConnectionChance)
                {
                    dungeon.TryConnect(a, b);
                }
            }
        }

        return dungeon;
    }

}
