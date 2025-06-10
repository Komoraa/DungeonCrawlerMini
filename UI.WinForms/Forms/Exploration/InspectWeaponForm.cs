using Items;

namespace UI.WinForms.Forms.Exploration;

public partial class InspectWeaponForm : Form
{
    private readonly Weapon _weapon;

    public InspectWeaponForm(Weapon weapon)
    {
        InitializeComponent();
        _weapon = weapon;
    }

    private void InspectWeaponForm_Load(object sender, EventArgs e)
    {
        TextBoxName.Text = _weapon.Name;
        TextBoxValue.Text = $"{_weapon.Value}";
        RichTextBoxDescription.Text = _weapon.Description;
        ListBoxAttacks.Items.AddRange([.. _weapon.Attacks]);
    }

    private void ButtonBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
