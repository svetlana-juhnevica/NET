using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine(" Enter command: ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "list":
                        library.List();
                        break;
                    case "mylist":
                        library.MyList();
                        break;
                    case "take":
                        library.Take();
                        break;
                    case "give":
                        library.Give();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Unrecognized command");
                        break;
                }
            }
        }
    }
}
