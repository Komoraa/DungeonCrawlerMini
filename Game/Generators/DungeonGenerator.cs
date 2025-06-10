using Characters;
using Dungeons;

namespace Game.Generators;

public static class DungeonGenerator
{
    public static Dungeon GenerateDungeon(int roomCount = 20, double extraConnectionChance = 0.3)
    {
        var random = new Random();
        var dungeon = new Dungeon();

        var startingRoom = RoomGenerator.GenerateRoom();
        dungeon.TryAdd(startingRoom);

        var rooms = new List<Room> { startingRoom };
        var secondRoom = RoomGenerator.GenerateRoom();
        if (dungeon.TryAdd(secondRoom))
        {
            dungeon.TryConnect(startingRoom, secondRoom);
            rooms.Add(startingRoom);
        }

        secondRoom.TryAdd(new Character { MaxHealth = 20, Health = 19 });

        for (int i = 2; i < roomCount; i++)
        {
            var newRoom = RoomGenerator.GenerateRoom();
            if (!dungeon.TryAdd(newRoom)) continue;

            var existingRoom = rooms[random.Next(rooms.Count)];
            dungeon.TryConnect(existingRoom, newRoom);
            rooms.Add(newRoom);

            foreach (var roomA in rooms)
            {
                foreach (var roomB in rooms)
                {
                    if (roomA == roomB) continue;
                    if (roomA == startingRoom || roomB == startingRoom) continue;

                    var connected = dungeon.ConnectionMap.TryGetValue(roomA, out var connections) &&
                        connections.Contains(roomB);

                    if (!connected && random.NextDouble() < extraConnectionChance)
                    {
                        dungeon.TryConnect(roomA, roomB);
                    }
                }
            }
        }

        return dungeon;
    }
}
