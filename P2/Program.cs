using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)

        /*
                    static void Task1()
                     {


                        Circle c1 = new Circle();

                       Console.WriteLine("Enter the radius: ");
                        c1.Radius = int.Parse(Console.ReadLine());
                        c1.Area();
                        c1.Perimeter();
                    Console.Read();

                    }
                   */

        /*{
            while (true)
            { 
            Console.WriteLine("Enter the shape (square, rectangle or circle):");
            string Shape = Console.ReadLine().ToLower();


                if (Shape == "square")
                {
                    Squaren square = new Squaren();
                    Console.WriteLine("Enter the Side length: ");
                    square.SideLength = int.Parse(Console.ReadLine());
                    square.Area();

                }
                else if (Shape == "rectangle")

                {

                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Enter the Side length: ");
                    rectangle.SideLength = int.Parse(Console.ReadLine());
                    rectangle.Area();
                    Console.Read();
                }

                else if (Shape == "circle")

                {
                    Circle circle = new Circle();
                    Console.WriteLine("Enter the Radius: ");
                    circle.Radius = int.Parse(Console.ReadLine());
                    circle.Area();
                    Console.Read();


                }



            }
    }

}
        }

    
    */
        {
            Tasks tasks = new Tasks();
            tasks.Task3();
            Console.Read();
        }
    }

}

