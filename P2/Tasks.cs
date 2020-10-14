using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Tasks
    {

        /* public void Task2()
             {
                 while (true)
                 {
                     Console.Write("Enter shape: ");
                     string shape = Console.ReadLine().ToLower();
                     switch (shape)
                     {
                         case "circle":
                             Console.WriteLine("Enter radius: ");
                             double radius = double.Parse(Console.ReadLine());
                             Circle circle = new Circle(radius);
                             circle.Area();
                             break;

                         case "rectangle":
                             Console.WriteLine("Enter side 1: ");
                             int side1 = int.Parse(Console.ReadLine());
                             Console.WriteLine("Enter side 2: ");
                             int side2 = int.Parse(Console.ReadLine());
                             Rectangle rectangle = new Rectangle(side1, side2);
                             rectangle.Area();
                             break;

                         case "squaren":
                             Console.WriteLine("Enter side: ");
                             int side = int.Parse(Console.ReadLine());
                             Squaren square = new Squaren();
                             square.Side = side;
                             square.Area();
                             break;
                         default:
                             Console.WriteLine("Unknown shape!");
                             break;
                     }
                     Console.WriteLine("Repeat? ");
                     string answer = Console.ReadLine().ToLower();
                     if(answer != "yes")
                     {
                         break;
                     }

                 }
             }
             */
        public void Task3()
        {
            Shop shop = new Shop();// total price raven 0; 
            shop.PrintCatalog(); //viveden katalog tovarov
            while (true)
            {
                Console.WriteLine("Enter item name: ");
                string name = Console.ReadLine().ToLower();

                if (name == "stop")
                {
                    // stops shopping
                    break;
                }
                shop.Buy(name);// vizovet metod buy esli ne stop, predlozhit kupij


            }
            Console.WriteLine("Total price = ${0}", shop.TotalPrice);


        }
    }

}

