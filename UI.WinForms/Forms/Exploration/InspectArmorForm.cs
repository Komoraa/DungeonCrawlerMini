using Items;

namespace UI.WinForms.Forms.Exploration.InspectItem;

public partial class InspectArmorForm : Form
{
    private readonly Armor _armor;

    public InspectArmorForm(Armor armor)
    {
        InitializeComponent();
        _armor = armor;
    }

    private void InspectArmorForm_Load(object sender, EventArgs e)
    {
        TextBoxName.Text = _armor.Name;
        TextBoxValue.Text = $"{_armor.Value}";
        RichTextBoxDescription.Text = _armor.Description;
        TextBoxAC.Text = $"{_armor.ArmorClass}";
    }

    private void ButtonBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
