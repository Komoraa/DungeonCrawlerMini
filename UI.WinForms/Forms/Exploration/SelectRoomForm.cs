using Dungeons;
using Game;

namespace UI.WinForms.Forms;

public partial class SelectRoomForm : Form
{
    private readonly GameState _state;

    public SelectRoomForm(GameState state)
    {
        InitializeComponent();
        _state = state;
    }

    private void SelectRoomForm_Load(object sender, EventArgs e)
    {
        var rooms = (from map in _state.Dungeon!.ConnectionMap
                     where (Room)map.Key == _state.CurrentRoom!
                     select map.Value).First();

        ListBoxRooms.Items.AddRange([.. rooms]);
        if (ListBoxRooms.Items.Count > 0)
        {
            ListBoxRooms.SelectedIndex = 0;
        }
        else
        {
            ButtonConfirm.Enabled = false;
        }
    }

    private void ButtonConfirm_Click(object sender, EventArgs e)
    {
        _state.CurrentRoom = ListBoxRooms.SelectedItem as Room;
        Close();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
