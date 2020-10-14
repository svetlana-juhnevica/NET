using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Rectangle : Figure
    {
        public int Side1;// 2 ipasibas
        public int Side2;
        public Rectangle(int side1, int side2)//konstruktors ar 2 ipasibam
        {
            Side1 = side1;
            Side2 = side2;
        }
        public override int Area()// metode override napolnjajet smislom abstraktnij metod
        {
            return Side1 * Side2;
        }
    }
}
