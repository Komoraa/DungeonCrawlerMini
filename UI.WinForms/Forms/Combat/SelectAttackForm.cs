using Actions;
using Characters;

namespace UI.WinForms.Forms.Combat;

public partial class SelectAttackForm : Form
{
    private readonly Character _player;
    private readonly Character _enemy;

    public SelectAttackForm(Character player, Character enemy)
    {
        InitializeComponent();
        _player = player;
        _enemy = enemy;
    }

    private void SelectAttackForm_Load(object sender, EventArgs e)
    {
        ListBoxAttacks.Items.AddRange([.. _player.Attacks]);
        if (ListBoxAttacks.Items.Count > 0)
        {
            ListBoxAttacks.SelectedIndex = 0;
        }
        else
        {
            ButtonConfirm.Enabled = false;
        }
    }

    private void ButtonConfirm_Click(object sender, EventArgs e)
    {
        var attack = ListBoxAttacks.SelectedItem as Attack;
        _player.TryAttack(attack!, _enemy);
        Close();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
