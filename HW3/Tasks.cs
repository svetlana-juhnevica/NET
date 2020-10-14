using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Tasks
    {
        public void Task1()
        {
            Console.WriteLine("Please write number 1:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write number 2:");
            int n2 = int.Parse(Console.ReadLine());

            int FinalDigit1 = n1 % (10);
            int FinalDigit2 = n2 % (10);
            if (FinalDigit1 == FinalDigit2)
            {

                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

            // Console>WriteLine(FinalDigit1 == FinalDigit2 ? "SAME" : "NOT SAME");
        }
        public void Task2()
        {



            Console.WriteLine("Enter your word: ");
            string word = Console.ReadLine().ToLower();
            int count = 0;
            foreach (char n in word)
            {
                if (n == 'e')
                {
                    count++;
                }

            }
            Console.WriteLine(count);
            //Console.WriteLine(word.Count(c => c == 'e' || c == 'E')); peremennaja word schitajet te simvoli kotorije ravni e
        }
        public void Task3()
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

            Console.WriteLine(count);
        }
        public void Task4()
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
            }
            if (numbers[0] == numbers[numbers.Count - 1])//numbers.First() == numbers.Last()
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            // Console.WriteLine(numbers.First() == numbers.Last()? "Equal" : "Not equal");
        }
        public void Task5()
        {


            Console.WriteLine("Enter number 1: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int m = int.Parse(Console.ReadLine());
            if (n > 21 && m > 21)
            {
                Console.WriteLine("0");
            }
            else if (n > 21)
            {
                Console.WriteLine(m);
            }

            else if (m > 21)
            {
                Console.WriteLine(n);
            }
            else if (n > m)
            {
                Console.Write(n);
            }
            else if (m > n)
            {
                Console.Write(m);
            }
            else
            {
                Console.Write("0");
            }
        }
        public void Task6()
        {
            ContactManager contacts = new ContactManager();
            while (true)
            {
                Console.Write("Enter command:");
                string command = Console.ReadLine().ToLower();
                if (command == "list")
                {
                    contacts.List();

                }
                else if (command == "add")
                {
                    contacts.Add();
                }
                else if (command == "delete")
                {
                    contacts.Delete();

                }
                else
                {
                    break;
                }
            }
        }
    }
}

