using Game;
using Game.Dtos;
using Game.Mappers;

namespace UI.WinForms.Forms
{
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
    }
}
