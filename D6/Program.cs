using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks tasks = new Tasks(); //tak vizivaem te metodi kotorije opredeljali new task= konstruktor klassa
            // StartValue = 50
            tasks.StartValue = 100; // v hode raboti startovuju mozhno menjatj
            // StartValue = 100
            tasks.Task1();
            tasks.Task2();
            Tasks tasks2 = new Tasks(333); // teperj vertiba bus 333 a ne ta chto ustanovili snchala

            ListExample list = new ListExample();
            list.AddNewTask("Learn C#");
            list.AddNewTask("Sleep");
            list.PrintAll();
            Console.Read();

        }
    }
}
