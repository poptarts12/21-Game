using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    internal class Card
    {
        public enum Shape
        {
            SPADE=0,
            DIAMOND=1,
            HEART=2,
            CLUB=3,
        }
        private  Shape shape;
        public int value;
        public Card(Shape shape, int value)
        {
            this.shape = shape;
            this.value = value;
        }
        public  Shape GetShape() => shape;
        public int GetValue() => value;
        public bool IsAce()
        {
            if (value == 1)
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
        public string GetDesc()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The value: " + value.ToString());
            sb.Append("\n");
            sb.Append("The Shape is: " + shape.ToString());
            return sb.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The value: " + value.ToString());
            sb.Append("\n");
            sb.Append("The Shape is: " + shape.ToString());
            return sb.ToString();
        }  
        
    }
}
