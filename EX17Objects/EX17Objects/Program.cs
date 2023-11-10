using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHandler;
using System.Collections.Generic;

namespace EX17Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            List<Car> cars = new List<Car>();

            Car car1 = new Car("Ford", "Mustang", 1966, "rød");
            Car car2 = new Car("Porsce", "911", 2004, "sølv");

            Console.WriteLine(car1.ToString());
            Console.WriteLine(car1.GetInfo());
            car1.Color = "blå";
            Console.WriteLine(car1.GetInfo());
            Console.WriteLine(car1.StartCar());


            cars.Add(car1);
            cars.Add(car2);
            Console.WriteLine("information om bilerne");

            foreach (Car c in cars)
            {
                Console.WriteLine(c.GetInfo());
            }
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }

            List<Car> cars1 = new List<Car>();
            Car bil = new Car("e", "e", 1966, "rød");
            // byte count = 0;
            while (true)
            {
                Console.WriteLine("\n-- Biladministration 1997 --\nØnsker du at:\n1. Indtaste en bil.\n2. Se informationer om indtastede biler.");
                Console.Write("Tast(1/2): "); byte indtast = Convert.ToByte(Console.ReadLine());

                // = Console.ReadLine();

                // Car h = Car.Make{ Console.ReadLine()};
                if (indtast==1) { 

                Console.Write("Lavet af: "); string Make = Console.ReadLine();
                Console.Write("Model: "); string Model = Console.ReadLine();
                Console.Write("År: "); int ProductionYear = Int32.Parse(Console.ReadLine());
                Console.Write("Farve: "); string Color = Console.ReadLine();
                // var bil = Convert.ToString(count);

                bil = new Car(Make, Model, ProductionYear, Color);
                //count++;
                cars1.Add(bil);
                }

                else if (indtast == 2 )
                {
                    foreach(Car c in cars1) { 
                        Console.WriteLine(bil.GetInfo());
                    }
                }
                else {
                    Console.WriteLine("fejl!");
                }
                

            }
        }

   
    }
}
