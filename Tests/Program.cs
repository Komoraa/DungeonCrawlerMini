using Characters;
using Core;
using Core.Enums;
using Core.Structs;
using Dungeons;
using Game;
using Game.Dtos;
using Game.Mappers;
using System.Text.Json;

namespace Tests;

internal class Program
{
    static void Main()
    {
        List<DieRoll> dieRolls = [
            new DieRoll(new Die(DieSize.D6), 4),
            new DieRoll(new Die(DieSize.D4), 2),
        ];
        AttackRoll attackRoll = new(dieRolls: [.. dieRolls]);
        Console.WriteLine(attackRoll);

        var fighter = new Character { Name = "Aaaaa" };

        fighter.OnInit += delegate { };
        fighter.OnLevelUp += delegate (object? sender, EventArgs e)
        {
            Console.WriteLine("Before: {0}", sender);
            if (sender is Character fighter)
            {
                fighter.Strength += 1;
            }
            Console.WriteLine("After: {0}\n", sender);
        };

        fighter.Init();

        //Console.WriteLine(fighter);

        fighter.LevelUp();
        fighter.LevelUp();
        fighter.LevelUp();

        //Console.WriteLine(fighter);

        fighter.GrantExperience(15000);

        //Console.WriteLine(fighter);

        var room1 = new Room { Name = "Room1" };
        var room2 = new Room { Name = "Room2" };
        var room3 = new Room { Name = "Room3" };

        var dungeon = new Dungeon { Name = null };
        dungeon.TryAdd(room1);
        dungeon.TryAdd(room2);
        dungeon.TryAdd(room3);

        dungeon.TryConnect(room1, room2);
        dungeon.TryConnect(room1, room3);
        dungeon.TryConnect(room3, room1);

        room1.Description = "asasasa";

        Console.WriteLine(dungeon);

        string fileName = "Fighter.json";
        string jsonString = JsonSerializer.Serialize(room1.ToDto());
        File.WriteAllText(fileName, jsonString);

        string jsonStringFromFile = File.ReadAllText(fileName);

        var roomDto = JsonSerializer.Deserialize<RoomDto>(jsonStringFromFile);

        Console.WriteLine();
        Console.WriteLine(roomDto?.ToEntity());

        File.WriteAllText(fileName, JsonSerializer.Serialize(dungeon.ToDto()));
        Console.WriteLine();
        Console.WriteLine(File.ReadAllText(fileName));
    }
}
