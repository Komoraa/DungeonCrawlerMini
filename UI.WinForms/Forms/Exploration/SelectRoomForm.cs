using Dungeons;
using Game;

namespace UI.WinForms.Forms;

public partial class SelectRoomForm : Form
{
    private readonly GameState _gameState;
    private readonly Dictionary<Room, Point> _roomPositions = [];

    public SelectRoomForm(GameState gameState)
    {
        _gameState = gameState;
        Text = "Minimap";
        DoubleBuffered = true;
        Size = new Size(800, 600);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (_gameState.Dungeon is null) return;

        var g = e.Graphics;
        var visited = _gameState.VisitedRooms;
        var map = _gameState.Dungeon.ConnectionMap;
        var rand = new Random(0); // consistent layout for demo

        // 1. Assign positions to visited rooms if not already done
        foreach (var room in visited)
        {
            if (!_roomPositions.ContainsKey(room))
            {
                _roomPositions[room] = new Point(rand.Next(50, 700), rand.Next(50, 500));
            }
        }

        // 2. Draw connections
        using var pen = new Pen(Color.Gray, 2);
        foreach (var room in visited)
        {
            if (!map.ContainsKey(room)) continue;
            var origin = _roomPositions[room];
            foreach (var dest in map[room].Where(visited.Contains))
            {
                var destPos = _roomPositions[(Room)dest];
                g.DrawLine(pen, origin, destPos);
            }
        }

        // 3. Draw rooms
        const int roomSize = 30;
        foreach (var room in visited)
        {
            var pos = _roomPositions[room];
            var rect = new Rectangle(pos.X - roomSize / 2, pos.Y - roomSize / 2, roomSize, roomSize);
            bool isCurrent = room == _gameState.CurrentRoom;
            using var brush = new SolidBrush(isCurrent ? Color.LimeGreen : Color.LightBlue);
            g.FillEllipse(brush, rect);
            g.DrawEllipse(Pens.Black, rect);

            // Room name
            var name = room.Name ?? "Room";
            var size = g.MeasureString(name, this.Font);
            g.DrawString(name, this.Font, Brushes.Black, pos.X - size.Width / 2, pos.Y + roomSize / 2);
        }
    }

    public void RefreshMap()
    {
        Invalidate(); // triggers OnPaint
    }
}
