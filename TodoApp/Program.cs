using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //"add", "do", "list, "exit";
            Tasks tasks = new Tasks();
            while(true)
            {
                Console.WriteLine("Enter command: ");
                string command = Console.ReadLine().ToLower();

                switch(command)// to lower mozhno bilo posle kommand
                {
                    case "add":
                        tasks.Add();//vizivajem kommandi iz klassa

                        break;
                    case "do":
                        tasks.Do();
                        break;

                    case "list":
                        tasks.List();
                        break;//partrauc tikai switch konstrukciju, ne while

                    case "exit":

                        return;//partrauc vispar visas darbibas, nado smotretj chtobi ne vikljuchil voobsche vse posledujuschije kommandi

                    default:
                        Console.WriteLine("Unknown command: ");
                        break;


                }
            }
        }
    }
}
