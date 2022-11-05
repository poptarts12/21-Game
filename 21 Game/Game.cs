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
            gameDeck = new Deck();
        }
        public void StartGame()
        {
            gameDeck.Shuffle();
            Console.WriteLine("hello to 21 black jack game.");
            // giving cards
            player2.GetCard(gameDeck.Deal());
            player2.GetCard(gameDeck.Deal());
            player1.GetCard(gameDeck.Deal());
            player1.GetCard(gameDeck.Deal());
            while (!IsGameOver())
            {
                for (currentPlayer = 0; currentPlayer < 2 ; currentPlayer++)
                {
                    Console.WriteLine("it's now" + GetCurrentPlayer().GetName() + " turn");
                    Console.WriteLine("if you want to take card write \"take\" else write every other thing");
                    Console.WriteLine("if you want to quit write -1");
                    if (Console.ReadLine() == "take")
                        GiveCurrentPlayerCard();
                    else if (Console.ReadLine() == "-1")
                        GetCurrentPlayer().Quit();
                        Console.WriteLine(GetCurrentPlayer().GetName() + "loose");
                        
                }

            }
        }
        public Player GetCurrentPlayer()
        {
            if (currentPlayer == 0)
                return player1;
            else return player2;
        }
        public void GiveCurrentPlayerCard() 
        {
            Player currentPlayer  = GetCurrentPlayer();
            currentPlayer.GetCard(gameDeck.Deal());
        }
        public bool IsGameOver()
        {
            if (player1.Lost()  || player2.Lost())
                return true;
            if (!player1.IsActive() || !player1.IsActive())
                return true;
            return false;
        }
        public Player GetWinner()
        {
            if (player2.GetPoints() == 21)
                return player2;
            if (player1.GetPoints() == 21)
                return player1;
            if (IsGameOver() && player2.IsActive())
                return player2;
            if (player1.IsActive() && IsGameOver())
                return player1;
            return null;
        }
        public override string ToString()
        {
            return "21 Blackjack game between" + player1.GetName() + "and" + player2.GetName();
        }
    }
}
