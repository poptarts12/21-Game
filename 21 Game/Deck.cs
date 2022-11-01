using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    internal class Deck
    {
        public List<Card> cards;
        public Deck() 
        {
            {
                for (int i = 0;i < 9;i++)
                {
                    Card card = new Card(Card.Shape.HEART,i);
                    cards.Add(card);
                }
                for (int i = 0; i < 9; i++)
                {
                    Card card = new Card(Card.Shape.SPADE, i);
                    cards.Add(card);
                }
                for (int i = 0; i < 9; i++)
                {
                    Card card = new Card(Card.Shape.DIAMOND, i);
                    cards.Add(card);
                }
                for (int i = 0; i < 9; i++)
                {
                    Card card = new Card(Card.Shape.CLUB, i);
                    cards.Add(card);
                }
            }
        }

    }
}
