using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EX20StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Values.txt"))
            {
                writer.WriteLine(4);
                writer.WriteLine(11);
                writer.WriteLine(91);
                writer.WriteLine(4);
                writer.WriteLine(64);
                writer.WriteLine(21);
                writer.WriteLine(25);
                writer.WriteLine(26);
                writer.WriteLine(1);
                writer.WriteLine(9);
            }


            // StreamReader reader = new StreamReader(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Values.txt");

            Console.WriteLine();

            using (StreamReader reader = new StreamReader(new FileStream(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Values.txt", FileMode.Open)))
            {
                string line;
                // Read line by line  
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            int sum = 0;
            byte counter = 0;
            Console.WriteLine();

            using (StreamReader read = new StreamReader(new FileStream(@"", FileMode.Open))) ;

            using (StreamReader reader = new StreamReader(new FileStream(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Values.txt", FileMode.Open)))
            {
                string line;
                // Read line by line  
                while (reader.EndOfStream != true)
                {
                    line = reader.ReadLine();
                    sum += Convert.ToInt32(line);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("line: " + line);
                    counter += 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("counter: " + counter);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("gennemsnit: " + Convert.ToInt32(sum / counter));


            // uden sum og counter, istedet List.

            Console.WriteLine("uden sum og counter, istedet List.");
            List<int> tal = new List<int>();

            using (StreamReader reader = new StreamReader(new FileStream(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Values.txt", FileMode.Open)))
            {
                string line;
                // Read line by line  
                while (reader.EndOfStream != true)
                {
                    line = reader.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("line: " + line);
                    tal.Add(Convert.ToInt32(line));
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("sum: " + tal.Sum());
            Console.WriteLine("gennemsnit: " + tal.Sum() / tal.Count());


            Console.WriteLine("metode: ");
            GetNumbersFromFile(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Values.txt");


            Box box = new Box(11, 15, 11);
            // box.PrintInfo();

            //Console.WriteLine(tal1);
            List<Box> boxes = new List<Box>();
            using (StreamReader reader = new StreamReader(new FileStream(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Boxes.txt", FileMode.Open)))
            {
                string line;
                // Read line by line  
                while (reader.EndOfStream != true)
                {
                    line = reader.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    // line.Split(',');
                    string[] array = line.Split(',');

                    Console.WriteLine("line: " + line);
                    foreach (string value in array)
                    {
                        Console.WriteLine($"Part: {value}");
                    }
                    box = new Box(Convert.ToInt32(array[0]), Convert.ToInt32(array[1]), Convert.ToInt32(array[2]));
                    box.CalculateVolume();
                    box.CalculateSurface();
                    boxes.Add(box);
                }
            }

            foreach (Box b in boxes)
            {
                b.PrintInfo();
            }

            Console.WriteLine("Metode: ");
            GetBoxesFromFile(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Boxes.txt");


            Person person = new Person("dank", "dark", 11);

            List<Person> personer = new List<Person>();

            using (StreamReader reader = new StreamReader(new FileStream(@"C:\Users\jona444j\source\repos\EX20StreamReader\EX20StreamReader\Personer.txt", FileMode.Open)))
            {
                while (reader.EndOfStream != true)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                    String[] array = line.Split(',');
                    person = new Person(array[0], array[1], Convert.ToByte(array[2]));

                    personer.Add(person);
                }
            }

            byte ældst = 1;
            // personer.alder.max
            for (byte i = 0; i < personer.Count; i++)
            {
                if (personer[i].Alder > personer[ældst].Alder)
                {
                    ældst = i; // er ældst
                }

            }
            Console.WriteLine("den ældste er: " + personer[ældst]);


            byte yngst = 1;
            for (byte i = 0; i < personer.Count; i++)
            {
                if (personer[i].Alder < personer[yngst].Alder)
                {
                    ældst = i; // er ældst
                }

            }
            Console.WriteLine("den yngste er: " + personer[yngst]);


            byte længst = 1;
            for (byte i = 0; i < personer.Count; i++)
            {
                if (personer[i].Fornavn.Length > personer[længst].Fornavn.Length)
                {
                    længst = i; // er ældst
                }

            }
            Console.WriteLine("det længste fornavn: "+ personer[længst]);

            byte kortest = 1;
            for (byte i = 0; i < personer.Count; i++)
            {
                if (personer[i].Fornavn.Length < personer[kortest].Fornavn.Length)
                {
                    kortest = i; // er ældst
                }

            }
            Console.WriteLine("det korteste fornavn: " + personer[kortest]);


            længst = 1;
            for (byte i = 0; i < personer.Count; i++)
            {
                if (personer[i].Fornavn.Length + personer[i].Efternavn.Length > personer[længst].Fornavn.Length + personer[længst].Efternavn.Length)
                {
                    længst = i; // er ældst
                }

            }
            Console.WriteLine("det længste navn: " + personer[længst]);

            kortest = 1;
            for (byte i = 0; i < personer.Count; i++)
            {
                if (personer[i].Fornavn.Length + personer[i].Efternavn.Length < personer[kortest].Fornavn.Length + personer[kortest].Efternavn.Length)
                {
                    kortest = i; // er ældst
                }

            }
            Console.WriteLine("det korteste navn: " + personer[kortest]);


            // find ud af hvilken en er højst





            // Console.WriteLine(personer);


            Console.ReadLine();
        }

        private static List<int> GetNumbersFromFile(string url)
        {
            List<int> tal1 = new List<int>();
            using (StreamReader reader = new StreamReader(new FileStream(url, FileMode.Open)))
            {
                string line;
                // Read line by line  
                while (reader.EndOfStream != true)
                {
                    line = reader.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("line: " + line);
                    tal1.Add(Convert.ToInt32(line));
                }
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("sum: " + tal1.Sum());
            Console.WriteLine("gennemsnit: " + tal1.Sum() / tal1.Count());

            return tal1;
            // throw new NotImplementedException();
        }

        private static List<Box> GetBoxesFromFile(string url)
        {
            Box box = new Box(1, 1, 1);
            List<Box> boxes = new List<Box>();
            using (StreamReader reader = new StreamReader(new FileStream(url, FileMode.Open)))
            {
                string line;
                // Read line by line  
                while (reader.EndOfStream != true)
                {
                    line = reader.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    // line.Split(',');
                    string[] array = line.Split(',');

                    Console.WriteLine("line: " + line);
                    foreach (string value in array)
                    {
                        Console.WriteLine($"Part: {value}");
                    }
                    box = new Box(Convert.ToInt32(array[0]), Convert.ToInt32(array[1]), Convert.ToInt32(array[2]));
                    box.CalculateVolume();
                    box.CalculateSurface();
                    boxes.Add(box);
                }
            }

            foreach (Box b in boxes)
            {
                b.PrintInfo();
            }
            return boxes;
            // throw new NotImplementedException();
        }
    }
}
