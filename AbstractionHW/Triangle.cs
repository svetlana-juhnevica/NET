using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionHW
{
   public class Triangle : Figure
    {
        public double Side1;
        public double Side2;
        public double Side3;
        
        public Triangle (double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

        }
        public override double Area()
        {
             double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt( p * ( p - Side1) * (p - Side2) * (p - Side3));
        }
        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
