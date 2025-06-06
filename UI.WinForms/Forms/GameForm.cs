using Game;
using Game.Dtos;
using Game.Mappers;

namespace UI.WinForms.Forms;

public partial class GameForm : Form
{
    public GameManager game;

    public GameForm(GameStateDto? dto = null)
    {
        InitializeComponent();
        GameState state;
        try
        {
            state = dto!.ToEntity();
        }
        catch
        {
            state = new();
        }

        game = new()
        {
            State = state
        };
        game.Start();
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {

    }
    private void ButtonSave_MouseEnter(object sender, EventArgs e)
    {

    }
    private void ButtonSave_MouseLeave(object sender, EventArgs e)
    {

    }

    private void ButtonInventory_Click(object sender, EventArgs e)
    {

    }
    private void ButtonInventory_MouseEnter(object sender, EventArgs e)
    {

    }
    private void ButtonInventory_MouseLeave(object sender, EventArgs e)
    {

    }

    private void ButtonMove_Click(object sender, EventArgs e)
    {

    }
    private void ButtonMove_MouseEnter(object sender, EventArgs e)
    {

    }
    private void ButtonMove_MouseLeave(object sender, EventArgs e)
    {

    }

    private void ButtonFight_Click(object sender, EventArgs e)
    {

    }
    private void ButtonFight_MouseEnter(object sender, EventArgs e)
    {

    }
    private void ButtonFight_MouseLeave(object sender, EventArgs e)
    {

    }

    private void ButtonLoot_Click(object sender, EventArgs e)
    {

    }
    private void ButtonLoot_MouseEnter(object sender, EventArgs e)
    {

    }
    private void ButtonLoot_MouseLeave(object sender, EventArgs e)
    {

    }
}
