using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.StartNew();
            
            while(true)
            {
                Console.Write("Guess!");
                if(number.Guess(int.Parse(Console.ReadLine())))// vizivaem metod gde razgadivaem
                {
                    break;
                }
            }

            Console.Read();

            
        }
    }
}
