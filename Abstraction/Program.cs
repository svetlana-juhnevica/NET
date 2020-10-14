using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 5);//vizivaem metod
            Square square = new Square(4);
            CalculateFigure(square);//tut mozhno CalculateRectangle, t.k. square vse nasleduet
            CalculateFigure(rectangle);
            Console.Read();
        }
        static void CalculateFigure(Figure figure)// metodes kas izsauc visus iespejamus aprekinus. klat var perimetru, ttk
        {
          Console.WriteLine("Area = {0}", figure.Area());
            //...
            //...
        }
          /* static void CalculateSquare(Square square)
        { 
            Console.WriteLine("Square area = {0}", square.Area());
        }
        */ 
        //eto nuzhno toljko esli dlja square budut specifich metodi kotorih net u rectangle
    }
}
