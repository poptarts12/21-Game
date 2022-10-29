using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    internal class Card
    {
        private  enum Shape
        {
            SPADE,
            DIAMOND,
            HEART,
            CLUB,
        }
        private static Shape shape;
        private int value;
        public Card(string shapeGot, int value)
        {
            shape = shapeGot;
            this.value = value;
        }
        public static enum 
    }
}
