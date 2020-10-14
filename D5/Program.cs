using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task19();
            //Task20();
            //Task20W();
            //Task21();
            ClassExample();


            Console.Read();
        }

        static void Task19()
        {

            Console.WriteLine("How many numbers? ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter your number: ");
                numbers[i] = int.Parse(Console.ReadLine());
                /*
                            }
                              int sum = 0;
                            foreach(int num in numbers) //mainiga, kur nonak katrs masivs
                            {
                                sum += num;

                            }
                            Console.WriteLine("Sum = {0}" , sum);
                            */
                Console.WriteLine("Sum = {0}", numbers.Sum());
            }
        }
        static void Task20()
        {
            /* List<int> numbers = new List<int>();
             numbers.Add(5); //0 pozicija
             numbers.Add(67);//1  pozicija
             //numbers[3] = 8; // pievienot tresajaa pozicijaaa

             foreach(int num in numbers)
             {

             }
             for(int i = 0; i < numbers.Count; i++) //soschitaet skoljko elementov v massive
             {
                 int num = numbers[i];

             }
 */
            List<int> numbers = new List<int>();
            for (; ; )
            {
                Console.WriteLine("Enter your number: ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                numbers.Add(num); //dobavim v spisok vse cifri krome 0

            }
            for(int i = numbers.Count - 1; i >= 0 ; i-- )
            {
                Console.WriteLine(numbers[i]);

            }

        }
        static void Task20W()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter your number: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                numbers.Add(n);
            }
        }
        static void Task21()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter your number or stop: ");
               string input = Console.ReadLine().ToLower();
                if (input == "stop")
                {
                    break;
                }
                int num = int.Parse(input);

                numbers.Add(num);

            }
            // find min & max
            int min = numbers[0];
            int max = numbers[0];
            foreach(int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                else if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Min = {0}, max = {1}", min, max);
        }
        //using built in methods:
        //Console.WriteLine("Min = {0}, max = {1}", numbers.Min(), numbers.Max());
    
        static void ClassExample()
        {
            Car carOne = new Car(); // Car- klase, carOne, carTwo- objekti
            carOne.Name = "VOLVO";
            carOne.Speed = 70;

            Car carTwo = new Car();
            carTwo.Name = "AUDI";
            carTwo.Speed = 60;

                carOne.Drive();
                carTwo.Drive();
                carTwo.Stop();
                carOne.Stop();

        }
        static void Squares()
        {
            Square s1 = new Square();
            s1.SideLength = 5;
            s1.Area();
            s1.Perimeter();
        }
    }

}
