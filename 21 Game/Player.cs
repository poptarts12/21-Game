using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    internal class Player
    {
        private string name;
        private List<Card> cards;
        private static int points;
        private int playerPoints;
        private bool active = true;
        public Player(string name)
        {
            this.name = name;
        }
        public string GetName() => name;
        public int GetPoints() => points;
        public int GetPlayerPoints() => playerPoints;
        public void GetCard(Card card)
        {
            cards.Add(card);
        }
        public void Quit() { active = false;}
        public void AddPoints(int points)
        {
            
        }

    }
}
