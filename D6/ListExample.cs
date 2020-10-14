using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class ListExample
    {
        public List<string> MyTasks;
        public ListExample()
        {
            MyTasks = new List<string>();

        }
        public void AddNewTask(string task)
        {
            MyTasks.Add(task);

        }
        public void PrintAll()
        {
            foreach(string task in MyTasks)
            {
                Console.WriteLine(task);
            }

        }
    }

}
