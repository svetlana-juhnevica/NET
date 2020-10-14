using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Car
    {
        public string Name;
        public int Speed;

        public void Drive()
        {
            Console.WriteLine("Car {0} is driving!", Name);
        }
        public void Stop()
        {
            Console.WriteLine("Car {0} stopped!", Name);
        }
    }
}
