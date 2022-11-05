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
        private int points;
        private bool active = true;
        public Player(string name)
        {
            this.name = name;
        }
        public string GetName() => name;
        public int GetPoints() => points;
        public int GetPlayerPoints() => points; //what the difrence??
        public void GetCard(Card card)
        {
            cards.Add(card);
            points += card.GetValue();
        }
        public void Quit() { active = false;}
        public bool IsActive() => active;
        public bool Lost()
        {
            if (points > 21 && !AceInCards())
                return true;
            else if (points > 21 && AceInCards())
            {
                for (int i = 0; i < cards.Count; i++)
                    if (cards[i].IsAce())
                        cards[i].SetValue(1);
                points = points - 10;
                if (points > 21)
                    return true;
                else return false;
            }
            else
                return false;
        }
        public bool AceInCards()
        {
            for (int i = 0; i < cards.Count; i++)
                if (cards[i].IsAce())
                    return true;
            return false;
        }
        public void AddPoints(int points)
        {
            this.points += points;
        }
        public override string ToString()
        {

            return "The player - " + name + "\nhave " + points + "points";
        }
    }
}
