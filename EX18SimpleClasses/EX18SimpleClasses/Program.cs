using System;
using System.Collections.Generic;

namespace EX18SimpleClasses
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Height height = new Height();
            Box box = new Box();
            box.CalculateVolume();
            box.CalculateSurface();
            Console.WriteLine(box.Height + "x" + box.Length1 + "x" + box.Width1);
            box.PrintInfo();

            /*Car car1 = new Car();

            car1.Make = "dacia";
            car1.Model = "Logan";
            car1.Color = "Rød";
            car1.Price = 170000;
            car1.IsSold = false;

            Car car2 = new Car();

            car2.Make = "Toyota";
            car2.Model = "Yaris";
            car2.Color = "Rød";
            car2.Price = 89000;
            car2.IsSold = true;

            car1.PrintInfo();
            car2.PrintInfo();*/

            Car myCar = new Car("Honda", "Civic", "Hvid", 199000, false);

            myCar.PrintInfo();
            myCar.PutOnSale();
            Console.WriteLine(myCar);
            myCar.PrintInfo();

            // menu
            // myCar.CreateCsv();
            myCar = new Car(@"C:\Users\jona444j\source\repos\EX18SimpleClasses\EX18SimpleClasses\csv.txt");
            Car newcar = new Car("Honda", "Civic", "Hvid", 199000, false);
            while (true)
            {

                Console.WriteLine("\n1. indtast ny bil\n2. se oversigt over biler\n3. sæt en bil på tilbud");
                byte menu = byte.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1: // indtast ny bil
                        Console.WriteLine("");
                        Console.Write("Hvem har lavet den? "); string Make = Console.ReadLine();
                        Console.Write("Hvilken model? "); string Model = Console.ReadLine();
                        Console.Write("Hviklen farve? "); string Color = Console.ReadLine();
                        Console.Write("Hvor meget koster den? "); int Price = int.Parse(Console.ReadLine());
                        bool forkert = true;
                        while (forkert == true)
                        {
                            forkert = false;
                            Console.Write("Er den til salg?(y/N) "); string sale = Console.ReadLine().ToLower();

                            if (sale == "y")
                            {
                                bool IsOnSale = true;
                                // forkert = false, også ikke forkert = false i toppen, men gør samme
                            }
                            else if (sale == "n")
                            {
                                bool IsOnSale = false;
                            }
                            else
                            {
                                Console.WriteLine("prøv igen");
                                forkert = true;
                            }

                        }
                        newcar = new Car(Make, Model, Color, Price, false);

                        myCar.Cars.Add(newcar);
                        // string car = Convert.ToString(myCar);
                        newcar.CreateCsv();
                        Console.WriteLine(myCar + " lavet og gemt");
                        break;

                    case 2: // se oversigt over biler
                        
                        Console.WriteLine("oversigt over biler: ");

                        byte i = 0;
                        //listed.PrintInfo();
                        foreach (Car c in myCar.Cars)
                        {
                            
                            //listed = new Car(@"C:\Users\jona444j\source\repos\EX18SimpleClasses\EX18SimpleClasses\csv.txt");
                            Console.Write(i+": ");
                            c.PrintInfo();
                            i++;
                        }

                        break;
                    case 3: // sætte en bil på tilbud
                        Console.Write("Hvilken bil vil du sætte på tilbud(indtast nummer): ");
                        byte nummer = byte.Parse(Console.ReadLine());

                        myCar.Cars[nummer].PutOnSale();


                        /*listed = listed.Cars[nummer];
                        //listed.PutOnSale();
                        listed.PrintInfo();*/
                        break;
                }
            }

            Console.WriteLine();

        }
    }
}
