using System;

namespace EX07SelectionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nhvilket program:\n1. rabat\n2. ens tal\n3. dividere\n4. største tal\n5. sigende orden\n6. Positiv eller negativ\n7. brev gram og priser");
                byte vælg = byte.Parse(Console.ReadLine());
                // switch til at vælge program

                switch (vælg)
                {
                    case 1:
                        float rabat = 0.05f;

                        Console.WriteLine("hvor meget køber du for? ");
                        int køber = int.Parse(Console.ReadLine());

                        if (køber > 1000)
                        {
                            Console.WriteLine("du får rabat: " + køber * rabat);
                        }
                        else
                        {
                            Console.WriteLine("du får ikke rabat");
                        }
                        break;

                    case 2:
                        Console.Write("skriv et tal: ");
                        int tal1 = int.Parse(Console.ReadLine());
                        Console.Write("skriv et til tal: ");
                        int tal2 = int.Parse(Console.ReadLine());
                        if (tal1 == tal2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("de to tal er ens");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("de to tal er ikke ens");
                            //Console.ForegroundColor = Reset;
                        }

                        break;

                    case 3: //division
                        Console.Write("skriv dit første tal at dividere med: ");
                        double inputOne = double.Parse(Console.ReadLine());
                    andet:
                        Console.Write("skriv dit andet tal at dividere med: ");
                        double inputTwo = double.Parse(Console.ReadLine());
                        if (inputTwo == 0)
                        {
                            Console.WriteLine("FEJL!");
                            goto andet;
                        }
                        else
                        {
                            Console.WriteLine("resultat: " + inputOne / inputTwo);
                        }

                        break;
                    case 4: // største tal
                        Console.Write("Første tal: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Andet tal: ");
                        int num2 = int.Parse(Console.ReadLine());
                        if (num1 > num2)
                        {
                            Console.WriteLine("det største tal er: " + num1);

                        }
                        else if (num1 < num2)
                        {
                            Console.WriteLine("det største tal er: " + num2);
                        }
                        else if (num1 == num2)
                        {
                            Console.WriteLine("de to tal er ens");
                        }
                        else
                        {

                        }

                        break;

                    case 5: // sigende orden
                        Console.Write("Første tal: ");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.Write("Andet tal: ");
                        int num4 = int.Parse(Console.ReadLine());
                        if (num3 >= num4)
                        {
                            Console.WriteLine(num3);
                            Console.WriteLine(num4);
                        }
                        else if (num3 <= num4)
                        {
                            Console.WriteLine(num4);
                            Console.WriteLine(num3);
                        }

                        break;

                    case 6: // positiv eller negativ
                        Console.Write("Skriv et tal: ");
                        int num5 = int.Parse(Console.ReadLine());
                        if (num5 < 0)
                        {
                            Console.WriteLine("negativt tal");
                        }
                        else if (num5 > 0)
                        {
                            Console.WriteLine("positivt tal");

                        }
                        else if (num5 == 0)
                        {
                            Console.WriteLine("det er nul");
                        }
                        break;
                    case 7: // brev gram og priser
                        Console.Write("Skriv hvor mange gram brevet vejer: ");
                        int num6 = int.Parse(Console.ReadLine());
                        int koster = 0;
                        if (num6 < 20)
                        {
                            //Console.WriteLine("koster 5,00kr");
                            koster = 5;
                        }
                        else if (num6 >= 20 && num6 < 50)
                        {
                            //Console.WriteLine("koster 7,00kr");
                            koster = 7;
                        }
                        else if (num6 >= 50 && num6 < 100)
                        {
                            koster = 10;
                            //Console.WriteLine("koster 10,00kr");
                        }
                        else if (num6 >= 100 && num6 < 150)
                        {
                            //Console.WriteLine("koster 15,00kr");
                            koster = 15;
                        }
                        else if (num6 >= 150 && num6 < 200)
                        {
                            koster = 20;
                            //Console.WriteLine("koster 20,00kr");
                        }
                        else
                        {
                            //Console.WriteLine("koster 30,00kr");
                            koster = 30;
                        }
                    eks:
                        Console.WriteLine("skal porto sendes ekspres? y/N");
                        string ekspres = Console.ReadLine().ToLower();
                        if (ekspres == "y")
                        {
                            koster = Convert.ToInt32(koster*1.5);
                            //continue;
                        }
                        else if (ekspres == "n")
                        {
                            continue;

                        }
                        else
                        {
                            goto eks;
                        }
                        Console.WriteLine("koster "+ koster+" kr.");


                        break;
                }

            }



        }
    }
}
