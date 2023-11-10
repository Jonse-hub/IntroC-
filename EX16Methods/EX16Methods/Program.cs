using System;

namespace EX16Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /*SayHello();
            SayGoodbye();*/

            SayHello("");
            Console.WriteLine();
            SayHello("Karsten");

            SayGoodbye();

            DoubleUp(10);
            Sum(10, 20);
            Størst(21, 11);
            string[] array = { "den", "det", "dat" };
            ArrayString(array);
        }

        private static void SayHello(string name) {
            Console.Write("Hello World! ");
            if (name == "Daniel")
            {
                Console.WriteLine("Daniel");
            }
            else if (name == "Karsten") {
                Console.WriteLine("Karsten");
            }

        }
        private static void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");

        }
        private static void DoubleUp(int tal)
        {
            tal = tal * 2;
            Console.WriteLine(tal);
        }

        private static void Sum(double tal1, double tal2)
        {
            double result = tal1 + tal2;
            Console.WriteLine(result);
        }
        private static void Størst(int tal1, int tal2)
        {
           
            Console.WriteLine();
            if (tal1 < tal2)
            {
                Console.WriteLine(tal2);
            }
            else
            {
                Console.WriteLine(tal1);
            }
        }
        private static void ArrayString(string[] array)
        {
            foreach(string isarray in array)
            {
                Console.WriteLine(isarray);
            }
        }
    }
}
