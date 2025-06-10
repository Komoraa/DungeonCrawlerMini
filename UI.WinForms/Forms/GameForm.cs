using Game;
using Game.Dtos;
using Game.Mappers;
using System.Text.Json;
using UI.WinForms.Forms.Characters;
using UI.WinForms.Forms.Combat;

namespace UI.WinForms.Forms;

public partial class GameForm : Form
{
    public readonly GameManager game;

    public GameForm(GameStateDto? dto = null)
    {
        InitializeComponent();
        if (dto is null) game = new();
        else game = new(dto.ToEntity());
    }

    private void Reload()
    {
        game.State.CurrentRoom!.Visited = true;
    }

    private void GameForm_Load(object sender, EventArgs e)
    {
        Reload();
    }

    private void ButtonInventory_Click(object sender, EventArgs e)
    {
        var form = new CharacterSheetForm(game.State);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
        var form = new InspectRoomForm(game.State);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ButtonFight_Click(object sender, EventArgs e)
    {
        var form = new SelectEnemyForm(game.State);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void ButtonMove_Click(object sender, EventArgs e)
    {
        var form = new SelectRoomForm(game.State);
        form.Show();
        form.FormClosed += delegate
        {
            Show();
            Reload();
        };
        Hide();
    }

    private void Save(string filePath)
    {
        var dto = game.State.ToDto();
        string content = JsonSerializer.Serialize(dto);
        File.WriteAllText(filePath, content);
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        using var saveFileDialog = new SaveFileDialog
        {
            Filter = "JSON files (*.json)|*.json",
            Title = "Save to a File",
            DefaultExt = "json",
            AddExtension = true
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                string filePath = saveFileDialog.FileName;

                Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading the save file:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

    private void ButtonQuit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
