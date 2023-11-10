using System;

namespace EX12ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<11; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i > 1; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 2; i<21; i=i+2)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 21; i = i + 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 70; i = i+7)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 130; i = i + 13)
            {
                Console.WriteLine(i);
            }
            Console.Write("skriv tabel: ");
            int tabel = int.Parse(Console.ReadLine());
            for (int i = 0;  i <= tabel*10; i = i + tabel)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 11; i++)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 2; i < 21; i = i + 2)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 3; i < 31; i = i + 3)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 4; i < 41; i = i + 4)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 5; i < 51; i = i + 5)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 6; i < 61; i = i + 6)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 7; i < 71; i = i + 7)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 8; i < 81; i = i + 8)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 9; i < 91; i = i + 9)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            for (int i = 10; i < 101; i = i + 10)
            {
                Console.Write(i.ToString().PadLeft(4));
            }
            Console.WriteLine();
            Random rand = new Random();
            int tilfældig = rand.Next(1, 11);

            for (int i = 0; i <10; i++)
            {
                tilfældig = rand.Next(1, 11);
                Console.WriteLine("10 forskellig: "+tilfældig);
            }
            tilfældig = 1;
            while (tilfældig != 6)
            {
                tilfældig = rand.Next(1, 11);
                Console.WriteLine("indtil 6: " + tilfældig);
            }
            

        }
    }
}
