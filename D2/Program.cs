using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task8();
            // Task9();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            Task15();


            Console.Read();
        }
        static void Task8()

        {
            Console.Write("Enter mathematical operation: ");
            string op = Console.ReadLine();

            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);

            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);

            }
            else if (op == "/")
            {
                Console.WriteLine((decimal)num1 / num2);

            }
        }
        static void Example()

        {
            Console.Write("Enter oeration: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Entered plus");
                    break;
                case "-":
                    Console.WriteLine("Entered minus");
                    break;
                case "*":
                    Console.WriteLine("Entered multiplication");
                    break;
                case "/":
                    Console.WriteLine("Entered division");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        static void Task9()

        {
            Console.WriteLine("Enter country name: ");
            string country = Console.ReadLine().ToLower();

            switch (country)
            {
                case "estonia":
                    Console.WriteLine("Tallin");
                    break;
                case "finland":
                    Console.WriteLine("Helsinki");
                    break;
                case "ukraine":
                    Console.WriteLine("Kyiv");
                    break;
                case "sweden":
                    Console.WriteLine("Stockholm");
                    break;
                case "russia":
                    Console.WriteLine("Moscow");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

        }
        static void Task11()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number is " + i);
            }

            /* i = i + 1;
             i++;
             ++i;
             i += 1;

     i = i + 3
     i = i--
     */
        }
        static void Task12()
        {
            Console.WriteLine("Enter you birth year: ");
            int year = int.Parse(Console.ReadLine());
            // for (int i = 2020; i >= year; i--)
            for (int i = year; i <= 2020; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Task13()
        {

            Console.WriteLine("Enter your number N: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                Console.WriteLine(i);
            }
            {
                Console.WriteLine("Sum =" + sum);
            }
        }


        static void Task14()

        {


            Console.WriteLine("How many numbers? ");

            int count = int.Parse(Console.ReadLine());
            decimal sum = 0;


            for (int i = 1; i <= count; i++)
            {

                Console.WriteLine("Enter number" + i + ": ");

                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            {
                Console.WriteLine("Sum =" + sum);
            }
            {
                Console.WriteLine("Average=" + sum / count);
            }
        }
        static void Task15()
        {

            Console.WriteLine("Enter your number N: ");
            int n = int.Parse(Console.ReadLine());
            // n = 5
            //
            // #
            // #
            // #
            // #
            // #

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}

    



        
    



           
            
            
            
        
    



