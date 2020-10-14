using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRental
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
                ListofReservations reservations = new ListofReservations(); 
                
            while (true)
            {
                reservations.PrintCatalog();
                reservations.Order();
                Console.WriteLine("Would you like to make another reservation? ");
                string input = Console.ReadLine().ToLower();

                if (input == "no" || input == "n")
                {

                     break;
                }

                Console.Clear();
            }




            
            
        }
    }
}
