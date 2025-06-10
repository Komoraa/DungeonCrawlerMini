using Game;
using Items;
using UI.WinForms.Forms.Exploration;
using UI.WinForms.Forms.Exploration.InspectItem;

namespace UI.WinForms.Forms;

public partial class CharacterSheetForm : Form
{
    private readonly GameState _state;

    public CharacterSheetForm(GameState state)
    {
        InitializeComponent();
        _state = state;
    }

    private void CharacterSheetForm_Load(object sender, EventArgs e)
    {
        ReloadInventory();
    }

    private void ReloadInventory()
    {
        var player = _state.Player!;
        object? selectedItem = ListBoxInventory.SelectedItem;

        TextBoxName.Text = player.Name;

        ProgressBarHealth.Value = 100 * player.Health / player.MaxHealth;

        TextBoxWeapon.Text = player.Weapon is null ? "None" : player.Weapon.Name;
        TextBoxArmor.Text = player.Armor is null ? "None" : player.Armor.Name;
        TextBoxAC.Text = $"{player.ArmorClass}";
        RichTextBoxDescription.Text = player.Description;
        TextBoxPP.Text = $"{player.Money.Platinum}";
        TextBoxGP.Text = $"{player.Money.Gold}";
        TextBoxSP.Text = $"{player.Money.Silver}";
        TextBoxCP.Text = $"{player.Money.Copper}";

        ListBoxInventory.Items.Clear();
        ListBoxInventory.Items.AddRange([.. _state.Player!.Inventory]);
        ListBoxInventory.SelectedItem = selectedItem;

        ButtonUse.Text = "Use";
        ButtonUse.Enabled = false;
        ButtonInspect.Enabled = false;
        ButtonDrop.Enabled = false;
    }

    private void ListBoxInventory_SelectedValueChanged(object sender, EventArgs e)
    {
        if (ListBoxInventory.SelectedIndices.Count != 1)
        {
            ButtonUse.Enabled = false;
            ButtonInspect.Enabled = false;
            ButtonDrop.Enabled = false;
            return;
        }
        else
        {
            ButtonUse.Enabled = true;
            ButtonInspect.Enabled = true;
            ButtonDrop.Enabled = true;
        }
        var player = _state.Player!;
        var selectedItem = ListBoxInventory.SelectedItem;
        if (selectedItem is Weapon || selectedItem is Armor)
        {
            ButtonUse.Text = "Equip";
            if (selectedItem == player.Weapon || selectedItem == player.Armor)
            {
                ButtonUse.Text = "Unequip";
            }
        }
    }

    private void ButtonUse_Click(object sender, EventArgs e)
    {
        var player = _state.Player!;
        var item = ListBoxInventory.SelectedItem as Item;
        if (item is Weapon || item is Armor)
        {
            if (ReferenceEquals(item, player.Weapon) || ReferenceEquals(item, player.Armor))
            {
                player.TryUnequip(item);
            }
            else
            {
                player.TryEquip(item);
            }
        }
        if (item is Potion)
        {
            player.TryUse(item);
        }
        ReloadInventory();
    }

    private void ButtonInspect_Click(object sender, EventArgs e)
    {
        var item = ListBoxInventory.SelectedItem as Item;
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

    private void ButtonDrop_Click(object sender, EventArgs e)
    {
        var item = ListBoxInventory.SelectedItem as Item;
        _state.Player!.TryDrop(item!);
        _state.CurrentRoom!.TryAdd(item!);
        ReloadInventory();
    }

    private void ButtonBack_Click(object sender, EventArgs e)
    {
        var player = _state.Player!;
        player.Name = TextBoxName.Text;
        player.Description = RichTextBoxDescription.Text;
        Close();
    }
}
