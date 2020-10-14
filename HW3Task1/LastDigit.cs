using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Task1
{
    class LastDigit
    {
        
        int Num1;
        int Num2;
        

      
        public void FindLastDigit()
        {
        Console.WriteLine("Please write number 1:");
        Num1 = int.Parse(Console.ReadLine());

        int FinalDigit1 = Num1 % (10);
    
        
        Console.WriteLine("Please write number 2:");
        Num2 = int.Parse(Console.ReadLine());

        int FinalDigit2 = Num2 % (10);
            if (FinalDigit1 == FinalDigit2)


                Console.WriteLine("Same");

            else

                Console.WriteLine("Not same");
            Console.Read();
        }
}

    }

