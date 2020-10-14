using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Tasks

    {
        public int StartValue;

        public Tasks ()
        {
            //konstruktor
            StartValue = 50; // nokluseta vertiba ar kuru sakt
        }
        public Tasks(int startValue)
        {
            StartValue = startValue; // chtobi ustanovitj konstruktor

        }

    public void Task1()
        {
            Console.WriteLine("This is task 1!");

        }
        public void Task2()
        {
            Console.WriteLine("This is task 2!");
        }
    }

}
