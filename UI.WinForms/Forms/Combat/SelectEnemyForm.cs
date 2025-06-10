using Characters;
using Game;

namespace UI.WinForms.Forms.Combat;

public partial class SelectEnemyForm : Form
{
    private readonly GameState _state;

    public SelectEnemyForm(GameState state)
    {
        InitializeComponent();
        _state = state;
    }

    private void Reload()
    {
        var enemies = _state.CurrentRoom!.Enemies;
        ListBoxEnemies.Items.Clear();
        ListBoxEnemies.Items.AddRange([.. from enemy in enemies where enemy.IsConscious select enemy]);
        if (ListBoxEnemies.Items.Count > 0)
        {
            ListBoxEnemies.SelectedIndex = 0;
        }
        else
        {
            ButtonConfirm.Enabled = false;
        }
    }

    private void SelectEnemyForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void ButtonConfirm_Click(object sender, EventArgs e)
    {
        var enemy = ListBoxEnemies.SelectedItem as Character;
        var form = new CombatForm(_state, enemy!);
        form.Show();
        form.FormClosed += delegate
        {
            Reload();
            Show();
        };
        Hide();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
