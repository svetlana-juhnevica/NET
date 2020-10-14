using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Circle
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public void Area()
        {
            Console.WriteLine("Area = {0}", Radius * Radius * Math.PI);

        }
       /* public void Perimeter()
        {
            Console.WriteLine("Perimeter = {0}", 3.14 * Radius * 2);
        }

    */
    }
}
