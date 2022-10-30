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
        public List<Card> cards;
        private static int points = 0;
        private bool active = true;
        public Player(string name)
        {
            this.name = name;
        }
        public string GetName() => name;
        public int GetPoints() => points;
        public void GetCard(Card card)
        {
            card
        }

    }
}
