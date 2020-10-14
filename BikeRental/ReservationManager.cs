using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    public class ReservationManager
    {
        public List<Bike> Bikes;
        public List<Reservation> Reservations;
        public ReservationManager ()
        {
            Bikes = new List<Bike>();
            Reservations = new List<Reservation>();
            Bikes.Add(new Bike("10", "B-Type Detroit", 2));
            Bikes.Add(new Bike("13", "Strurdy Bike", 1.5m));
            Bikes.Add(new Bike("22", "Lightspeed drift", 1));
        }
        public List<Bike> GetAllBikes()
        {
            return Bikes.OrderBy(b => b.Number).ToList();
        }
        public string Reserve(string number, int period, string )
        {
            //1. parbaudit vai velo eksiste
            if(!Bikes.Exists(b =>b.Number == number))
            {
                return "Bike not found!";
            }
            //2. Parbaidit vai nav rezervets
            if(Reservations.Exists(b =>b.Bike.Number == number && b.StartTime <= DateTime.Now && b.EndTime >= DateTime.Now))
            {
                return "Bike already reserved!";
            }
            //3/ Veic rezervaciju (papildina Reservations sarakstu)
            {
                var bike = Bikes.Find(b => b.Number == number);
                Reservations.Add(new Reservation(email, period, bike));
                decimal totalPrice = bike.Price * period;
                return  String.Format"You reserved bike for {0}!,";
            }
        }
    }
}
