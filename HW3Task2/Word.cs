using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Task2
{
    class Word
    {

        public string word;



        public void CountLetters()
        {
            int count = 0;


            Console.WriteLine("Enter your word: ");
            word = Console.ReadLine().ToLower();

            foreach (char n in word)
            {
                if (n == 'e')
                    count++;
            }
          
            {     
            Console.WriteLine(count);
            }
        }
    }

    }

            

        
    

