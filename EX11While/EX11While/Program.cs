using System;

namespace EX11While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int tal = 0;
            while (tal < 10)
            {
                Console.WriteLine(tal);
                tal++;
            }
            while (tal >= 1)
            {
                Console.WriteLine(tal);
                tal--;
            }
            while (tal <= 20)
            {
                tal++;
                if (tal % 2 == 0)
                {
                    Console.WriteLine(tal);
                }
                else { continue; }

            }
            while (tal >= 1)
            {
                tal--;
                if (tal % 2 != 0)
                {
                    Console.WriteLine(tal);
                }
                else { continue; }

            }
            Console.WriteLine("opg 2:");

            while (tal < 70)
            {
                tal = tal + 7;
                Console.WriteLine(tal);
            }
            tal = 0;
            while (tal < 130)
            {
                tal = tal + 13;
                Console.WriteLine(tal);
            }

            // hvilken som helst tabel:
            Console.Write("skriv tabel: ");
            tal = 0;
            int tabel = Convert.ToInt32(Console.ReadLine());

            while (tal < tabel * 10)
            {
                tal = tal + tabel;
                Console.WriteLine(tal);

            }
            bool fortsæt = true;
            while (fortsæt)
            {
                Console.Write("indtast et tal mellem et og ti: ");
                byte ti = Convert.ToByte(Console.ReadLine());
                if (ti <= 10 && ti >= 1)
                {
                    Console.WriteLine("godt!");
                    fortsæt = false;
                }
                else
                {
                    continue;
                }
            }


        }
    }
}
