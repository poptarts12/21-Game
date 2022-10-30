using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    internal class Game
    {
        private Player player1;
        private Player player2;
        private Deck gameDeck;
        private int currentPlayer = 0; //0 is pl1. 1 is pl2
        public Game(string pl1,string pl2)
        {
            player1 = new Player(pl1);
            player2 = new Player(pl2);
        }
        public Player GetCurrentPlayer()
        {
            if (currentPlayer == 0)
                return player1;
            return player2;
        }

    }
}
