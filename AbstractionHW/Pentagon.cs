using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionHW
{
  
        public class Pentagon : Figure
        {
            public double Side1;
           

            public Pentagon(double side1)
            {
                Side1 = side1;
                
            }
        public override double Area()
            {
                
                return Side1 * Math.Sqrt(25 + 10 * Math.Sqrt(5)/ 4);
            }
            public override double Perimeter()
            {
                return Side1 * 5;
            }
        }
    }


