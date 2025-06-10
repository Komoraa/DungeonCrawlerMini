using Characters;
using Items;

namespace UI.WinForms.Forms.Combat;

public partial class SelectItemForm : Form
{
    private readonly Character _player;

    public SelectItemForm(Character player)
    {
        InitializeComponent();
        _player = player;
    }

    private void Reload()
    {
        ListBoxInventory.Items.AddRange([.. _player.Inventory]);
        if (ListBoxInventory.Items.Count > 0)
        {
            ListBoxInventory.SelectedIndex = 0;
        }
        else
        {
            ButtonConfirm.Enabled = false;
        }
    }

    private void SelectItemForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void ButtonConfirm_Click(object sender, EventArgs e)
    {
        var item = ListBoxInventory.SelectedItem as Item;
        if (item is Weapon weapon)
        {
            _player.TryEquip(weapon);
        }
        else if (item is Armor armor)
        {
            _player.TryEquip(armor);
        }
        else if (item is Potion potion)
        {
            _player.TryUse(potion);
        }
        Close();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
