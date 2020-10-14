using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Task3
{
    class NumberDivision
    {
        public void Count5DivisibleNumbers()
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    count++;

                }
            }
                
                Console.WriteLine(count);// ne ponimaju, kuda eto, inache ne vivodit kolichestvo

            }
        }
           
           
        
        
                
    }

