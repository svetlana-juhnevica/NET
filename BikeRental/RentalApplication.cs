using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
   public class RentalApplication
    {
        public ReservationMangaer
        public RentalApplication()
        {

        }
        public void Start()
        {
            ShowList();
            while(true)
            {
                Console.Write("Do you want to make a reservation?");
                string answer = Console.ReadLine().ToLower();
               if(answer == "yes" || answer =="y")
                {
                    MakeReservation();
                }
                else
                {
                    break;
                }
            }
           
        }
        public void ShowList()
        {
            Console.WriteLine("Available bikes: ");
            foreach(var bike in AppDomainManager.GetAllBikes())
            {
                Console.WriteLine("{0} - {1}, EUR {2}/h", bike.)
            }

        }
        public void MakeReservation()
        {
            Console.Write("Enter bicycle numer: ");
            string number = Console.ReadLine();
            Console.Write("Enter rental period: ");
            int period  = int.Parse(Console.ReadLine());
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            //reservacijas logikas izsaukums
            string result = Manager.Reserve(number, period, email);
            Console.
        }
    }
}
