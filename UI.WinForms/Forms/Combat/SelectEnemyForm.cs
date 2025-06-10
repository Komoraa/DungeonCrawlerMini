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
}
