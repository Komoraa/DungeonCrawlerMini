using Items;

namespace UI.WinForms.Forms.Exploration;

public partial class InspectPotionForm : Form
{
    private readonly Potion _potion;

    public InspectPotionForm(Potion potion)
    {
        InitializeComponent();
        _potion = potion;
    }

    private void InspectPotionForm_Load(object sender, EventArgs e)
    {
        TextBoxName.Text = _potion.Name;
        TextBoxValue.Text = $"{_potion.Value}";
        RichTextBoxDescription.Text = _potion.Description;
        ProgressBarHealth.Value = 100 * _potion.Health / _potion.MaxHealth;
    }

    private void ButtonBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
