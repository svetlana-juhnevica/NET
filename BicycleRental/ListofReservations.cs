using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRental
{
    class ListofReservations
    {

        public List<Bicycle> Bicycles;



        public List<Reservation> Reservations;


        public ListofReservations()
        {


            Bicycles = new List<Bicycle>();// definejam sarakstu
            Reservations = new List<Reservation>();
            Bicycles.Add(new Bicycle(10, "B-Type Detroit Bike"));
            Bicycles.Add(new Bicycle(13, "Sturdy bike X400"));
            Bicycles.Add(new Bicycle(22, "Lightspeed drift"));
            Bicycles.Add(new Bicycle(30, "Marlin bike 5er"));
            Bicycles.Add(new Bicycle(47, "Atlas rise for kids"));

        }
        public void PrintCatalog()
        {

            Console.WriteLine("Available bicycles: ");
            foreach (Bicycle i in Bicycles)
            {
                Console.WriteLine("{0} {1} $ per hour{2}", i.Number, i.Name, i.Price);

            }
        }
        public void Order()
        {
            Console.WriteLine("Enter the number of the bicycle you want to rent: ");
            int wantedBicycle = int.Parse(Console.ReadLine());

            if (BicycleExists(wantedBicycle) == false)
            {
                Console.WriteLine("Bicycle does not exist");
            }
            else

            {
                ReturnBicycle();

                if (IsRented(wantedBicycle))
                {
                    Console.WriteLine("This bicycle is already rented!");
                    
                }
                else
                {
                    Console.WriteLine("Enter the rental period (hours): ");
                    int period = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your email: ");
                    string email = Console.ReadLine();
                    Reservations.Add(new Reservation(wantedBicycle, period, email));
                    string bicycleName = GetBicycleName(wantedBicycle);
                    Console.WriteLine("You have successfully rented a bicycle {0}", bicycleName);
                     PrintRentedBicycleList(email);
                }
            }
        }
        public bool BicycleExists(int wantedBicycle)
        {
            bool bicycleExists = false;
            foreach (Bicycle i in Bicycles)
            {
                if (i.Number == wantedBicycle)
                {
                    //item found
                    bicycleExists = true;
                }
            }
            return bicycleExists;

        }


        public void ReturnBicycle()
        {
            foreach (Reservation e in Reservations)
            {
                if (e.End < DateTime.Now)
                {
                    Reservations.Remove(e);
                }
            }
        }


        public bool IsRented(int bicycleNumber)
        {
            bool isRented = false;
            foreach (Reservation order in Reservations)
            {
                if (order.BicycleNumber == bicycleNumber)
                {
                    isRented = true;
                    break;
                }
            }
            return isRented;

        }
       
        public string GetBicycleName(int wantedBicycle)
        {
            string bicycleName = string.Empty;
            foreach (Bicycle i in Bicycles)
            {
                if (i.Number == wantedBicycle)
                {
                    bicycleName = i.Name;
                    break;
                }

            }
            return bicycleName;
        }
    

        public void PrintRentedBicycleList(string userEmail)
        {
            Console.WriteLine("Reserved bicycles by {0}:", userEmail);
           
            foreach (Reservation order in Reservations)
            {
                if (order.Email == userEmail)
                {
                    
                    Console.WriteLine("{0} {1}", order.BicycleNumber, GetBicycleName(order.BicycleNumber));
                }
            }
           
        }
       
    }

}



    




    

