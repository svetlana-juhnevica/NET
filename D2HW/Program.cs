using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2HW
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
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            // Task12();
            Task13();


            Console.Read();

        }
        static void Task1()
        {
            Console.Write("Enter word number one: ");
            String word1 = Console.ReadLine();



            Console.Write("Enter word number two: ");
            String word2 = Console.ReadLine();


            Console.Write("Enter word number three: ");
            String word3 = Console.ReadLine();


            Console.Write(word1 + " " + word2 + " " + word3);
        }
        static void Task2()
        {
            Console.Write("Enter your age :");
            int age = int.Parse(Console.ReadLine());
            if (age < 50)
            {
                Console.WriteLine("Your age is under 50");
            }
            else if (age > 50)
            {
                Console.WriteLine("Your age is over 50");
            }
            else if (age == 50)
            {
                Console.WriteLine("You are 50");
            }
        }

        static void Task3()
        {
            {
                /* Console.Write("Enter number 1: ");
                 int num1 = int.Parse(Console.ReadLine());

                 Console.Write("Enter number 2: ");
                 int num2 = int.Parse(Console.ReadLine());

                 if (num1 == num2)
                 {
                     Console.WriteLine("Number 1 equals number 2");
                 }
                 else if (num1 > num2)
                 {
                     Console.WriteLine("Number 1 does not equal number 2");
                 }
                 else if (num1 < num2)
                 {
                     Console.WriteLine("Number 1 does not equal number 2");
                 }
                 */
                {
                    Console.Write("Enter number 1: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num1 == num2);
                }

            }
        }


        static void Task4()

        {

            {
                Console.WriteLine("Enter number 1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number 3: ");
                int num3 = int.Parse(Console.ReadLine());

                int sum = num1 + num2 + num3;
                Console.WriteLine("The average value of your three numbers is: " + sum / 3);
            }
        }
        static void Task5()
        {
            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine((n >= -50 && n <= 50));

        }
        static void Task6()
        {

            Console.Write("Enter your number: ");
            int N = int.Parse(Console.ReadLine());
            int j = N * 2;
            for (; N <= j; N++)
            {
                Console.WriteLine(N);
            }
        }
        static void Task7()
        {
            Console.Write("Enter your number: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)

            {
                if (i == 5)
                {
                    continue;
                }


                {
                    if (i == 10)

                    {
                        continue;
                    }

                }
                Console.WriteLine(i);
            }
        }
        static void Task8()
        {
            Console.WriteLine("Enter number 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 3: ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("The largest number is: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("The smallest number is: " + Math.Min(x, Math.Min(y, z)));
        }
        static void Task9()
        {
            Console.WriteLine("Enter your number: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 != 0)
            {
                Console.WriteLine("Your number is odd");
            }
            else if (x % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
        }
        static void Task10()
        {
            Console.WriteLine("Enter your number 1: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your number 2: ");
            int B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i);
                }
            }
        }
        static void Task11()
        {
            Console.WriteLine("Enter your line count: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                for (int x = i; x <= count; x++)
                {
                    Console.Write("*");
                }
                for (int y = 1; y < i; y++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Task12()
        {
            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n != 0)

            {
                sum += n % 10;
                n /= 10;

            }
            Console.WriteLine("Sum of the digits of your number is " + sum);

        }
        static void Task13()
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int i, j, k = 1;
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0 }", k++);


                }
                Console.WriteLine();

            }
        }
        
    }
}



    

    






    


        
    



