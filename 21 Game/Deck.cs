using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    internal class Deck
    {
        private List<Card> cards;
        public Deck() 
        {
           cards =  CreateCardsDeck();
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            for(int i = 0;i < cards.Count; i++)
            {
                int randomIndex = rnd.Next(0, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }
        public Card Deal()
        {
            Card card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return card;
        }
        public int Count() => cards.Count;

        public bool IsEmpty() => cards.Count == 0;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cards.Count; i++)
            {
                sb.Append(cards[i]);
                sb.Append(", ");
            }
            return sb.ToString();
        }
        private static List<Card> CreateCardsDeck()
        {
            List<Card> cards = new List<Card>();
            for (int i = 2; i < 15; i++)
                foreach (Card.Shape j in Enum.GetValues(typeof(Card.Shape)))
                {
                    if (i <= 10) //num cards
                    {
                        Card card = new Card(j, i);
                        cards.Add(card);
                    }
                    else if (i < 14) // picture cards
                    {
                        Card card = new Card(j, 10);
                        cards.Add(card);
                    }
                    else //ace cards
                    {
                        Card card = new Card(j, 11);
                        cards.Add(card);
                    }
                }
            return cards;
        }

    }
}
