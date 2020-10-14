using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Task5
{
    class NumberComparison
    {
       
         public void ClosestNumber()
        {
            int targetNumber = 21;
            Console.WriteLine("Enter number 1: ");
           int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
           int m = int.Parse(Console.ReadLine());
            if ((Math.Abs(targetNumber - n) < Math.Abs(targetNumber - m)) && targetNumber <= n)
            {
                Console.WriteLine(n);
            }
            else if((Math.Abs(targetNumber - n) > Math.Abs(targetNumber - m)) && targetNumber <= m)
                    {
                Console.WriteLine(m);
            }

            else if(n == m)
                    {
                Console.WriteLine("0");

            }
        }
    }
}
