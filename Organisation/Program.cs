using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organisation
{
    class Program
    {
        static void Main(string[] args)
        {
            // usage examples:
            Organisation org = new Organisation("SIA mans uznemums");
            org.AddEmployee("Kaija", "Putnina", "01 / 01 / 1980");
            org.AddEmployee("Dzidra", "Zupa", "25 / 05 / 1979");
            org.AddEmployee("Rudolfs", "Briedis", "24 / 12 / 1983");
            org.Fire("Dzidra", "Zupa");
            org.ChangeDate("Rudolfs", "Briedis", "24/12/1973");

            org.PrintAllEmployees();
            Console.Read();









        }
    }
}


    

