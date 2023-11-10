using System;
using System.IO;
using System.Collections.Generic; 


namespace EX21StreamWriter
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (StreamWriter writer = new StreamWriter(@"C:\Users\jona444j\Desktop\MyFile.txt")) // 
            {
                // Writes text on a line
                writer.Write("Dette bliver skrevet på linje");
                writer.Write(".. og det her fortsætter på samme linje");
                // Writes text on a line, followed by a linebreak
                writer.WriteLine(".. det her står på samme linje, men afsluttes med nyt linjeskift");
                writer.WriteLine("Forskellen på Write og WriteLine er altså om den bliver afsluttet med nyt linjeskift eller ej");
                writer.WriteLine("1");
                writer.WriteLine("2");


                Random rand = new Random();

                for (byte i = 0; i < 100; i++)
                {
                    writer.WriteLine(rand.Next(1, 7));
                }
            }
            hvormangeHvor(100, @"C:\Users\jona444j\Desktop\RandomNumbers.txt");

            List<int> randnums = new List<int>();
            using (StreamReader reader = new StreamReader(new FileStream(@"C:\Users\jona444j\Desktop\RandomNumbers.txt", FileMode.Open)))
            {

                string line;
                while (reader.EndOfStream != true)
                {
                    line = reader.ReadLine();

                    randnums.Add(Convert.ToInt32(line));
                }
            }
            randnums.Sort();

            foreach(int i in randnums)
            {
                Console.WriteLine(i);
            }
            /*int d = 1;
            foreach(int i in randnums)
            {
                Console.WriteLine(i);
            }*/
            int tal1 = 0;
            int tal2 = 0;
            int tal3 = 0;
            int tal4 = 0;
            int tal5 = 0;
            int tal6 = 0;

            foreach (int i in randnums)
            {
                switch (i)
                {
                    case 1:
                        tal1++;
                        break;
                    case 2:
                        tal2++;
                        break;
                    case 3:
                        tal3++;
                        break;
                    case 4:
                        tal4++;
                        break;
                    case 5:
                        tal5++;
                        break;
                    case 6:
                        tal6++;
                        break;
                }
            }

            Console.WriteLine("1-taller: " + tal1);
            Console.WriteLine("2-taller: " + tal2);
            Console.WriteLine("3-taller: " + tal3);
            Console.WriteLine("4-taller: " + tal4);
            Console.WriteLine("5-taller: " + tal5);
            Console.WriteLine("6-taller: " + tal6);

        }
        private static void hvormangeHvor(int tilfældig, string url)
        {
            Random rand = new Random();
            using (StreamWriter writer = new StreamWriter(url)) // @"C:\Users\jona444j\Desktop\MyFile.txt"
            {
                for (int i = 0; i < tilfældig; i++)
                {
                    writer.WriteLine(rand.Next(1, 7));
                }
            }
        }

    }
}
