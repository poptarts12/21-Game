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
        public Card(Shape shape, int value)
        {
            this.shape = Shape.shape;
            this.value = value;
        }
        public  Shape GetShape() => shape;
        public int GetValue() => value;
        public bool IsAce()
        {
            if (value == 1 || value == 11)
                return true;
            else
                return false;
        }
        public bool IsPictureCard()
        {
            if (value == 10)
                return true;
            else 
                return false;
        }
        public override string ToString()
        {

        }  
        
    }
}
