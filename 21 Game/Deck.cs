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
            
            //picture cards adding:
            for (int i = 0; i < 12; i++)
            {
                Card card = new Card(Card.Shape.CLUB, 10);
                cards.Add(card);
            }
        }
        private  void CreateNumCards()
        {
            for (int i = 1; i < 10; i++)
            {
                Card card = new Card(Card.Shape.HEART, i);
                cards.Add(card);
            }
            for (int i = 1; i < 10; i++)
            {
                Card card = new Card(Card.Shape.SPADE, i);
                cards.Add(card);
            }
            for (int i = 1; i < 10; i++)
            {
                Card card = new Card(Card.Shape.DIAMOND, i);
                cards.Add(card);
            }
            for (int i = 1; i < 10; i++)
            {
                Card card = new Card(Card.Shape.CLUB, i);
                cards.Add(card);
            }
        }
        private void CreatePictureCards()
        {
            //picture cards adding:
            for (int i = 0; i < 12; i++)
            {
                Card card = new Card(Card.Shape.CLUB, 10);
                cards.Add(card);
            }
        }

    }
}
