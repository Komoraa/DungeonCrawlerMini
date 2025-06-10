using Dungeons;
using Game;

namespace UI.WinForms.Forms;

public partial class InspectRoomForm : Form
{
    private readonly GameState _state;

    public InspectRoomForm(GameState state)
    {
        InitializeComponent();
        _state = state;
    }

    private void InspectRoomForm_Load(object sender, EventArgs e)
    {
        var currentRoom = _state.CurrentRoom!;
        TextBoxName.Text = currentRoom.Name;
        ListBoxEnemies.Items.AddRange([.. currentRoom.Enemies]);
        ListBoxItems.Items.AddRange([.. currentRoom.Items]);

        var rooms = (from map in _state.Dungeon!.ConnectionMap
                     where (Room)map.Key == currentRoom
                     select map.Value).First();

        ListBoxRooms.Items.AddRange([.. rooms]);
    }

    private void ButtonBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
