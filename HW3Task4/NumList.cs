using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Task4
{
    class NumList
    {
        

        public void NumberList()
        {

            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter your number or stop: ");
                string input = Console.ReadLine().ToLower();
                if (input == "stop")
                {
                    break;
                }
                int num = int.Parse(input);

                numbers.Add(num);
                
                Console.WriteLine(numbers.First() == numbers.Last());

            }

        }
            }
    }

        
    

