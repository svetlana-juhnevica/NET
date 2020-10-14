using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Tasks
    {
        public List<string> MyTasks;
        public Tasks()
        {
        MyTasks = new List<string>();
        }
         
        public void Add()
        {
            //"add" asks to enter task description
            //and adds it to the user's todo list
            Console.WriteLine("Enter task descritpion: ");
            MyTasks.Add(Console.ReadLine());
            // vai:
            //string task = Console.ReadLine();
            //MyTasks.Add(task);
        }
    public void Do()
        {
            //"do" asks to enter task number and remves
            //corresponding tssk from the user's todo list
            // If a task with an entered number doen't exist,
            // a message should be printed "Task not found"
            Console.WriteLine("Enter task number: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= MyTasks.Count || num < 0)
            {
                Console.WriteLine("Task not found!");
            }
            else
            {
                MyTasks.RemoveAt(num);
                List();//chtobi posle stiranija pokazalsja spisok
            }
        }
    public void List()
        {
            //"list" shows all tasks in the user's list
            //and their sequence numbers;
            //if there are no tasks, a message should be 
            //printed:"You don't have any upcoming task!"

            if (MyTasks.Count == 0)
            {
                Console.WriteLine("You don't have any upcoming task!");
            }
            else
            {
                for (int i = 0; i < MyTasks.Count; i++)

                {
                    Console.WriteLine("{0}; {1}", i, MyTasks[i]);//krome nazvanija, budet nomer zadanija
                }
            }
        }
    }


}
