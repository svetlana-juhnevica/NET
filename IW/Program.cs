using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Hangman();
            Hangman2();





            Console.Read();

        }
        static void Task1()
        {
            Console.WriteLine("Enter number: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = N; i >= 1; i--)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
        static void Task2()
        {
            Console.WriteLine("Enter number: ");
            int N = int.Parse(Console.ReadLine());
            if (N % 3 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Enter weekday (e.g. M, Tu, W, Th, F, Sa, Su): ");
            String name = Console.ReadLine();

            if (name == "M" || name == "Tu" || name == "W" || name == "Th" || name == "F")
            {
                Console.WriteLine("alarm " + name + "-> 7:00");
            }
            else
            {
                Console.WriteLine("alarm " + name + "-> 10:00");

            }

        }
        static void Task4()
        {
            Console.WriteLine("Are you on vacation?");
            String vacation = Console.ReadLine();
            Console.WriteLine("Enter weekday (e.g. M, Tu, W, Th, F, Sa, Su): ");
            String name = Console.ReadLine();


            if (vacation == "No")
            {

                if (name == "M" || name == "Tu" || name == "W" || name == "Th" || name == "F")
                {
                    Console.WriteLine("alarm " + name + "-> 7:00");
                }
                else
                {
                    Console.WriteLine("alarm " + name + "-> 10:00");

                }
            }
            else
            {
                if (name == "M" || name == "Tu" || name == "W" || name == "Th" || name == "F")
                {
                    Console.WriteLine("alarm " + name + "-> 10:00");
                }
                else
                {
                    Console.WriteLine("alarm is off ");

                }
            }
        }

        static void Task5()
        {
            Console.WriteLine("Enter number 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            int i = num1;

            for (i = num1; i <= num2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");


                    continue;

                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");


                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        static void Task6()
        {
            Console.WriteLine("Enter number : ");
            int num = int.Parse(Console.ReadLine());
            int i, j;

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)

                    Console.Write("" + (j));
            }
            {
                Console.Write("");
            }
        }
        static void Task7()
        {
            Console.WriteLine("Enter number : ");// number of rows
            int rows = int.Parse(Console.ReadLine());
            int i, j, spc, k;
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)

            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");

                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", i);
                Console.Write("\n");
                spc--;
                /* Console.WriteLine("Enter number : ");// number of rows
            int rows = int.Parse(Console.ReadLine());
            //  1
               2 2
              3 3 3
              for (int r = 1; r<= n; r++)
              {
              for(int s = 1; s ,+ n-r; s++)
              {
              Console.Write(" ");
              }
              for (int d = 1; d<= 2 *r -1; d++
              //for(int d=1; d<= r; d++
              {
              Console.Write("{0} , r)
              }
              */
                //Console.WriteLine();

            }

        }
        static void Hangman()
        {
            string[] listofwords = new string[7] { "blue", "white", "green", "black", "yellow", "red", "brown" };
            Random randGen = new Random();
            var idx = randGen.Next(0, 6);
            string guessedword = listofwords[idx];
            char[] guess = new char[guessedword.Length];
            Console.WriteLine("Enter your guess ");

            for (int x = 0; x < guessedword.Length; x++)
                guess[x] = '_';


            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int y = 0; y < guessedword.Length; y++)
                {
                    if (playerGuess == guessedword[y])
                        guess[y] = playerGuess;


                }
                Console.WriteLine(guess);


            }
        }
        static void Hangman2()
        {
            string[] listofwords = new string[7] { "blue", "white", "green", "black", "yellow", "red", "brown" };
            Random randGen = new Random();
            var idx = randGen.Next(0, 6);
            string guessedword = listofwords[idx];
            char[] guess = new char[guessedword.Length];

            for (int x = 0; x < guessedword.Length; x++)
                guess[x] = '_';


            Console.WriteLine("Enter your guess ");
            bool isFound = false;
            char playerGuess = char.Parse(Console.ReadLine());
            for (int y = 0; y < guessedword.Length; y++)
            {
                if (playerGuess == guessedword[y])
                 guess[y] = playerGuess;


                }

            


            if (!isFound)

            {
                Console.WriteLine("wrong ");
            }



        }
    }
}


        

        



        
                
            






               
            

    



