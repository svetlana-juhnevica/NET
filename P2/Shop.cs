using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Shop
    {
        public List<Item> Items; //budet spisok s nazvanijami i cenami
        public int TotalPrice;

        public Shop()
        {

            TotalPrice = 0;
                Items = new List<Item>();// definejam sarakstu
                Items.Add(new Item("PC", 900));
                Items.Add(new Item("Pants", 50));
                Items.Add(new Item("Car", 10000));
                Items.Add(new Item("Mobile", 500));

            }
            public void PrintCatalog()
            {

                Console.WriteLine("Available items: ");
                    foreach(Item i in Items)
                {
                    Console.WriteLine("{0} ${1}", i.Name, i.Price);

                }
            }
            public void Buy(string name)
            {
            bool itemFound = false;
            foreach (Item i in Items)
            {
                if (i.Name.ToLower() == name)
                {
                    //item found
                    itemFound = true;
                    TotalPrice += i.Price;
                    break;

                }

            }
                if (!itemFound)
                {
                    Console.WriteLine("Item not found!");

                }

            }
            
        
    }
}
