using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListItems
{
    class Items
    {
        public string ItemName;
        public int Price;
        public List<string> Item;
        public List<int> Price;
        public Items()

        {
            Item = new List<string>();

        }
        public void AddNewItem(string ItemName)
        {
            Item.Add(ItemName);

        }
        public void AddNewPrice(int Price);
        {
            Price.Add(Price);

        }
        public void TotalAmount()
        {
            Console.WriteLine("Total amount:");
        }
        
        
        
