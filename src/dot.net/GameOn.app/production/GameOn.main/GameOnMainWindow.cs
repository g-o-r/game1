using System.Windows.Forms;

namespace GameOn.main
{
    public delegate void RenderTurnDelegate();

    public partial class GameOnMainWindow : Form, IRenderer, IInputNotifier
    {
        public GameOnMainWindow()
        {
            InitializeComponent();
            Game game = new Game();
            game.AddPerson();
            GameDrawer drawer = new GameDrawer(this, game);
            GameInputGatherer gatherer = new GameInputGatherer(this, game);
            game.Start();
        }

        internal void RenderTurn()
        {
            if (InvokeRequired)
            {
                Invoke(new RenderTurnDelegate(RenderTurn));

                return;
            }
            this.Text = (int.Parse(this.Text) + 1).ToString();

        }

    }
}
