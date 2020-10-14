using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    class Bike
    {
        public string Title;
        public string Number;
        public decimal Price;
        public Bike(string number, string title, decimal price);
        {
            Number = number;
            Title = title;
            Price = price;
    }
}
}
