using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            // Task2();
            //Task3();
            //Task4();
            //Task6();
            //Task7();
            Task5();



            // teksta izvade
            // Console.WriteLine("Hello!");
            // Console.Write("Hello again!");

            //lai Console logs paliek atverts
            Console.Read();
        }

        static void Task1()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Your name is " + name);
        }
        static void Task2()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();


            Console.WriteLine("Your name is " + name + " " + surname);
        }
        static void Task3()
        {
            Console.Write("Enter number 1:  ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2:  ");

            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;

            Console.WriteLine("Sum = " + (num1 + num2));


        }
        static void Task4()
        {
            Console.Write("Enter number 1:  ");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2:  ");

            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Sum = " + (num1 + num2));


            Console.WriteLine("Diff = " + (num1 - num2));


            Console.WriteLine("Multi = " + (num1 * num2));


            Console.WriteLine("Div = " + (num1 / num2));


        }
        static void Task6()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are underage!");

            }
            else if (age == 18)
            {
                Console.WriteLine("You are 18!");

            }
            else
            {
                Console.WriteLine("You are over 18!");

            }
        }

        static void Task7()

        {
            Console.Write("Enter number 1:  ");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2:  ");

            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");

            }
            else if (num1 < num2)
            {
                Console.WriteLine("Number #1 is less than number #2");

            }
            else
            {
                Console.WriteLine("Number #1 is greater than number #2");
            }
        }
static void Task5()

        {
            Console.Write("Enter degrees Celsius: ");
            int degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Degrees Fahrenheit = " + (degrees * 1.8000 + 32.00));
            Console.WriteLine("Degrees Kelvin = " + (degrees + 273.15));
        }
    }




    }

