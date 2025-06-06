using Game.Dtos;
using System.Text.Json;

namespace UI.WinForms.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void SetUpGame(GameStateDto? dto = null)
    {
        var game = new GameForm(dto);
        game.Show();
        game.FormClosed += delegate
        {
            Close();
        };
        Hide();
    }

    private void ButtonContinue_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog()
        {
            Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
            Title = "Load a Save File"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                string filePath = openFileDialog.FileName;
                string jsonContent = File.ReadAllText(filePath);

                var data = JsonSerializer.Deserialize<GameStateDto>(jsonContent);

                SetUpGame(data);
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

    private void ButtonNewGame_Click(object sender, EventArgs e)
    {
        SetUpGame();
    }
}
