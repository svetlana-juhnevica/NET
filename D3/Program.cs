using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task17();
            Task18();
            {
                Console.Read();

                /* static void Task16()
                {
                    Console.WriteLine("Enter the degrees: ");
                        decimal deg = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter unit: ");
                    string unitFrom = Console.ReadLine().ToLower();
                    Console.WriteLine("Enter new unit: ");
                    string unitTo = Console.ReadLine().ToLower();

                    if(unitFrom == unitTo)
                    {
                        Console.WriteLine(deg + unitTo);
                    }
                    else
                    {
                        switch(unitFrom)
                        {
                            case "c":
                                switch(unitTo)
                                {
                                    case "k":
                                        // c_> k
                                         //c-> f
                                        //Console.WriteLine((degrees + 273) + "K");
                                        Console.WriteLine("{0}K", deg + 273);
                                        //Console.WriteLine("{0} {1}", degrees + 273, "K");
                                        break;
                                    case "f":
                                       // c -> F
                                        break;

                                }
                        }
                    }
                    //int F = int.Parse(Console.ReadLine());

                    // int C = int.Parse(Console.ReadLine());

                    //int K = int.Parse(Console.ReadLine());

                    switch (deg)
                    {
                        case C
                            Console.WriteLine("Degrees Celsius" + deg);
                            break;
                        case F
                            Console.WriteLine("Degrees Fahrenheit" + );
                            break;
                        case K
                            Console.WriteLine("Degrees Kelvin" + );
                            break;
                    }
                }
            }

        }
    }
    */
                /*static void Example()
                            {
                                // new empty array with 4 elements
                                int[] numbers = new int[4];
                                numbers[0] = 5;
                                numbers[1] = 3;
                                numbers[2] = 9;
                                numbers[3] = 56;
                                // error - index out of range:
                                numbers[4] = 7;
                                Console.WriteLine("First number = {0}", numbers[0]);
                                int[] numbers2 = { 5, 3, 9, 56 };
                                for (int i = 0; i < numbers.Length; i++)
                                {
                                    int num = numbers[i];
                                    Console.WriteLine(num);
                                }
                                foreach (int num in numbers)
                                {
                                    Console.WriteLine(num);
                                }

                                }
                                */
            }
            //static void Task17()


            {

                Console.WriteLine("Enter your number: ");
                int N = int.Parse(Console.ReadLine());
                int[] numbers = { 0, 10, 20, 30, 40, 50 }; //definet masivu ar skaitliem
                bool isFound = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (N == numbers[i])
                    {
                        isFound = true;
                        Console.WriteLine("Number found at position {0}", i);
                        break;

                    }
                }
                // if(isFound == false)
                if (!isFound)
                {
                    Console.WriteLine("Number not found ");
                }
            }

            
        }

        static void Task18()
        {

            // 1. user enters count N
            Console.WriteLine("Enter count: ");
            int n = int.Parse(Console.ReadLine());

            // 2. Define array for N elements
            int[] numbers = new int[n];

            // 3. User enters N numbers - store in array (using for loop0.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }
            // 4. Find all even numbers in array (using foreach)
            {
                int count = 0;
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        count++;

                    }
                    Console.WriteLine("{0} even numbers entered", count);
                }
                

    }
        }
    }
}






        
    

      

               
           
       