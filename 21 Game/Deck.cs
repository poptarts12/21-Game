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
            CreateNumCards();
            CreatePictureCards();
            CreateAce();
        }
        public void Shuffle()
        {
            int len = cards.Count();
            Random rnd = new Random();
            for(int i = 0;i < len;i++)
            {
                int randomIndex = rnd.Next(0, len);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }
        public Card Deal()
        {
            Random rnd = new Random();
            int len = cards.Count();
            int randomIndex = rnd.Next(0, len);
            Card card = cards[randomIndex];
            cards.Remove(cards[randomIndex]);
            return card;
        }
        public int Count()
        {
            return cards.Count();
        }
        private bool IsEmpty()
        {
            if (Count() == 0)
                return true;
            return false;
        }
        public override string ToString()
        {

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
        private void CreateAce()
        {
            for (int i = 0; i < 4; i++)
            {
                Card card = new Card(Card.Shape.CLUB, 1);
                cards.Add(card);
            }
        }
    }
}
