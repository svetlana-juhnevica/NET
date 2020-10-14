using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRental
{
    class Reservation
    {
       public int BicycleNumber;
       public int Period;
       public string Email;
        public DateTime Start;
        public DateTime End;
        public Reservation(int bicycleNumber, int period, string email)
        {
            BicycleNumber = bicycleNumber;
            Period = period;
            Email = email;
            Start = DateTime.Now;
            End = Start.AddHours(period);
        }
    }
}
