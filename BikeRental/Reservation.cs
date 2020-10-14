using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
  public  class Reservation
    {
        public string Email;
    
        public Bike Bike;
        public DateTime StartTime;
        public DateTime EmdTime;
        public Reservation (string email, int period, Bike bike)
        {
            Email = email;
          
            Bike = bike;
            StartTime = DateTime.Now;
            EndTime = StartTime.AddHours(period);
        }
    }
}
