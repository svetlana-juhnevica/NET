using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        public string Name;

        public string Surname;
        public string Currency;
        public decimal Balance;
        
        public Account(string name, string surname, string currency)
        {
            Name = name; // konstruktor
            Surname = surname;
            Currency = currency;
            Balance = 0;

             
        }
        public void GetBalance()
        {
            
            Console.WriteLine("Your balance is: {0}",  Balance);
        }
        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?: ");
           decimal plus = decimal.Parse(Console.ReadLine());
           

            if (plus > 10000)
            {
                Console.WriteLine("An error");
            }
            else
                
            {
                Console.WriteLine("{0} {1} deposited,", plus, Currency);
                Balance += plus;
            }

            
        }
        public void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?: ");
            decimal minus = decimal.Parse(Console.ReadLine());
           

            if (minus > 500)
            {
                Console.WriteLine("An error");
            }
            else if(Balance < minus)
                {
                Console.WriteLine("Not enough money");
            }
             else   
            {
                Console.WriteLine("{0} {1} withdrawn", minus, Currency);
                Balance -= minus;
            }
        }
    }
}

