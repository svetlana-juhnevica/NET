using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionHW
{
    public class Square : Pentagon
    {
       
        public Square(double side1)
            : base(side1)
        {

        }
           
        
        public override double Area()
        {
            return Side1 * Side1;

            
        }
        public override double Perimeter()
        {
            return Side1 * 4;
        }
    }
}