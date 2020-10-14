using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organisation
{
    class Organisation
    {

        public string Title;
        public List<Employee> Employees;
        public Organisation(string title)
        {
            Title = title;
            Employees = new List<Employee>();
            Console.WriteLine("New organisation created - {0}, Title");??

        }
        public void AddEmployee(string name, string surname, string date)
        {

            Employees.Add(new Employee(name, surname, date));
            Console.WriteLine("Employee added - {0}. {1}.", name[0], surname);
        }
        public void Fire(string name, string surname)
        {
            int position = -1;
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Name.ToLower() == name.ToLower() && Employees[i].Surname.ToLower() == surname.ToLower())
                {
                    position = 1;
                    break;
                }
            }

            if (position == -1)
            {
                Console.WriteLine("Employee not found!");

            }
            else
            {
                Employees.RemoveAt(position);
                Console.WriteLine("Employee fired - {0} {1}.", name, surname);
            }
        }
        public void Fire2(string name, string surname)
        {
            //lambda expression
            Employee employee = Employees.Find(e => e.Name == name && e.Surname == surname);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
            }
            else
            {
                Employees.Remove(employee);//RemoveAll udalit vseh
                Console.WriteLine("Employee fired - {0} {1}.", name, surname);
            }
        }
        public void ChangeDate(string name, string surname, string newDate)
        {
               foreach (var emp in Employees)    //var nosakt tipu automatiski
            {
                if (emp.Name == name && emp.Surname == surname)
                    {
                        emp.BirthDate = newDate;        //replacing type
                    Console.WriteLine("Employee's {0} {1} date changed!", name, surname);
                    break;
                    }
        }

        }
        public void PrintAllEmployees()
        {

            Console.WriteLine("Organisation {0} employees: " ,Title);
            foreach (var emp in Employees)
            {
                Console.WriteLine("{0} {1}, {2}", emp.Name, emp.Surname, emp.BirthDate);

            }
        }
        
           
                

            }
        }
    

