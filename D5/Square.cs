using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Square
    {
        public int SideLength;
        public void Area()
        {
            Console.WriteLine("Area = {0}", SideLength * SideLength);
        }
            public void Perimeter()
        {
            Console.WriteLine("Perimeter = {0}", SideLength * 4);
        }



            
    }
}
