using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionHW
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Square s1 = new Square(5);
            s1.Perimeter();
            s1.Area();
            Triangle t1 = new Triangle(5, 3, 4);
            t1.Perimeter();
            t1.Area();
            Pentagon p1 = new Pentagon(5);
            p1.Perimeter();
            p1.Area();
            CalculateAreaAndPerimeter(s1);//tut mozhno CalculateRectangle, t.k. square vse nasleduet
            CalculateAreaAndPerimeter(t1);
            CalculateAreaAndPerimeter(p1);
            Console.Read();
        }
        static void CalculateAreaAndPerimeter(Figure figure)// metodes kas izsauc visus iespejamus aprekinus. klat var perimetru, ttk
        {
            Console.WriteLine("Area = {0}", figure.Area());
            Console.WriteLine("Perimeter = {0}", figure.Perimeter());
            //...
        }
    }
    }

