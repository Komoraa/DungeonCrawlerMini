using Dungeons;
using Game;
using Items;
using UI.WinForms.Forms.Exploration;
using UI.WinForms.Forms.Exploration.InspectItem;

namespace UI.WinForms.Forms;

public partial class InspectRoomForm : Form
{
    private readonly GameState _state;

    public InspectRoomForm(GameState state)
    {
        InitializeComponent();
        _state = state;
    }

    private void Reload()
    {
        var currentRoom = _state.CurrentRoom!;
        TextBoxName.Text = currentRoom.Name;
        ListBoxEnemies.Items.Clear();
        ListBoxItems.Items.Clear();
        ListBoxRooms.Items.Clear();

        ListBoxEnemies.Items.AddRange([.. currentRoom.Enemies]);
        ListBoxItems.Items.AddRange([.. currentRoom.Items]);

        var rooms = (from map in _state.Dungeon!.ConnectionMap
                     where (Room)map.Key == currentRoom
                     select map.Value).First();

        ListBoxRooms.Items.AddRange([.. rooms]);

        if (ListBoxItems.Items.Count > 0)
        {
            ListBoxItems.SelectedIndex = 0;
        }
        else
        {
            ButtonItemPickUp.Enabled = false;
            ButtonItemInspect.Enabled = false;
        }
    }

    private void InspectRoomForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void ButtonItemPickUp_Click(object sender, EventArgs e)
    {
        var item = ListBoxItems.SelectedItem as Item;
        if (_state.CurrentRoom!.TryRemove(item!)) _state.Player!.TryPickUp(item!);
        Reload();
    }

    private void ButtonItemInspect_Click(object sender, EventArgs e)
    {
        var item = ListBoxItems.SelectedItem as Item;
        if (item is Weapon weapon)
        {
            var form = new InspectWeaponForm(weapon);
            form.Show();
            form.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }
        else if (item is Armor armor)
        {
            var form = new InspectArmorForm(armor);
            form.Show();
            form.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }
        else if (item is Potion potion)
        {
            var form = new InspectPotionForm(potion);
            form.Show();
            form.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }
    }

    private void ButtonBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
