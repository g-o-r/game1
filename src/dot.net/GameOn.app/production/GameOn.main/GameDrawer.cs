using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOn.main
{
    public class GameDrawer
    {
        private GameOnMainWindow gameOnMainWindow;
        private Game game;

        public GameDrawer(GameOnMainWindow gameOnMainWindow, Game game)
        {
            this.gameOnMainWindow = gameOnMainWindow;
            this.game = game;
           // game.NewTurnStarted += gameOnMainWindow.RenderTurn();
            game.NewTurnStarted += new NewTurnStartedEventHandler(game_NewTurnStarted);
        }

        void game_NewTurnStarted(object sender, EventArgs e)
        {
            gameOnMainWindow.RenderTurn();
        }

    }
}
