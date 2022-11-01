using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    internal class Program
    {

        public enum Shape
        {
            SPADE = 0,
            DIAMOND = 1,
            HEART = 2,
            CLUB = 3,
        }
        public Shape shape;
        static void Main(string[] args)
        {
            Console.WriteLine(Card.Shape.HEART);
        }
    }
}
