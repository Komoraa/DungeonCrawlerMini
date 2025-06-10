using Game.Dtos;
using System.Text.Json;

namespace UI.WinForms.Forms;

public partial class MainForm : Form
{
    private GameStateDto? _save;

    public MainForm()
    {
        InitializeComponent();
    }

    private void ButtonPlay_Click(object sender, EventArgs e)
    {
        var game = new GameForm(_save);
        game.Show();
        game.FormClosed += delegate
        {
            Close();
        };
        Hide();
    }

    private void LoadSave(string filePath)
    {
        const string messageCorruptedFile = "Corrupted Save Data!";

        string content = File.ReadAllText(filePath);

        var data = JsonSerializer.Deserialize<GameStateDto>(content) ?? throw new Exception(messageCorruptedFile);

        if (data.Player is null) throw new Exception(messageCorruptedFile);
        if (data.Dungeon is null) throw new Exception(messageCorruptedFile);
        if (data.CurrentRoom.Equals(0)) throw new Exception(messageCorruptedFile);

        _save = data;
    }

    private void ButtonLoadSave_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog
        {
            Filter = "JSON files (*.json)|*.json",
            Title = "Load a Save File"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                string filePath = openFileDialog.FileName;
                
                LoadSave(filePath);

                ButtonPlay.Text = "Continue";
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

    private void ButtonExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
