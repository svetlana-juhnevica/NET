using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    class Number
    {
        public int Num;

        public void StartNew()
        {

            Num = new Random().Next(1, 201);
        }
        public bool Guess(int userGuess)
        {
            if (userGuess == Num)
            {
                Console.WriteLine("You've got it");
                return true;
            }
            else if (userGuess < Num)
            {
                Console.WriteLine("No, it's a larger number");
            }
            else if (userGuess > Num)
            {
                Console.WriteLine("No, it's a smaller number");
            }
            return false;
        }
    }

    }
