using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //"get balance", "Deposit", "Withdraw, "exit";
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your currency: ");
            string currency = Console.ReadLine();
            

            Account account = new Account(name, surname, currency);

            Console.WriteLine(name + " " + surname + " ," +  currency);
        
            while (true)
            {
                Console.WriteLine("Enter command: ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "get balance":
                        account.GetBalance();

                        break;
                    case "deposit":
                        account.Deposit();
                        break;

                    case "withdraw":
                        account.Withdraw();
                        break;

                    

                    default:
                        Console.WriteLine("Unknown command: ");
                        break;


                }
            }
        }
    }
}
