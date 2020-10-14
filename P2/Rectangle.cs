using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Rectangle
    {
        public int Side1;
        public int Side2;
        public Rectangle (int side1, int side2)
        {
            Side1 = side1; // konstruktor
            Side2 = side2;

        }
        public void Area()
        {
            Console.WriteLine("Area = {0}", Side1 * Side2);
        }
        


    }
}
