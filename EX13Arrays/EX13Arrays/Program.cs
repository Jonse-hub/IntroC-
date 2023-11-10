using System;
using System.Collections.Generic;

namespace EX13Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[5];
            ages[0] = 25;
            ages[1] = 28;
            ages[2] = 15;
            ages[3] = 35;
            ages[4] = 14;

            Console.WriteLine(ages[0]);

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }

            string[] names = new string[4] { "Hans", "Anton", "Betinna", "Daniel" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            names[3] = "Kong Daniel";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


            int[] numbers = new int[10] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Array.Sort(numbers); // sorteret fra lav til høj

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Array.Reverse(numbers); // omvendt sortering
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + 5);
            }

            Random rand = new Random();
            rand.Next();

            int[] arraytilfælding = new int[10] { rand.Next(), rand.Next(), rand.Next(), rand.Next(), rand.Next(), rand.Next(), rand.Next(), rand.Next(), rand.Next(), rand.Next() };
            for (int i = 0; i < arraytilfælding.Length; i++)
            {
                Console.WriteLine(arraytilfælding[i] + 5);
            }



            Console.WriteLine("lister!");

            List<int> agesl = new List<int>();

            agesl.Add(5);
            agesl.Add(17);
            agesl.Add(20);
            agesl.Add(40);
            agesl.Add(51);

            List<string> namesl = new List<string>();

            namesl.Add("jens");
            namesl.Add("Karl");
            namesl.Add("Johannes");
            namesl.Add("Anton");
            namesl.Add("Niklas");

            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };
            List<bool> areMarried = new List<bool>() { true, false, false, true, true };

            for (int i = 0; i < agesl.Count; i++)
            {
                Console.WriteLine(agesl[i]);
            }

            for (int i = 0; i < namesl.Count; i++)
            {
                Console.WriteLine(namesl[i]);
            }

            foreach (double percentage in percentages)
            {
                Console.WriteLine(percentage);
            }
            foreach (bool isMarried in areMarried)
            {
                Console.WriteLine(isMarried);
            }

            List<string> navne = new List<string>() { "Hans", "Kristian", "Jens", "Karsten", "Ib" };

            foreach (string isnavne in navne)
            {
                Console.WriteLine(isnavne);
            }
            navne.Insert(3, "Anders");
            // Hans, kristan, anders, jens, forkert anders sidst......
            foreach (string isnavne in navne)
            {
                Console.WriteLine(isnavne);
            }

            List<int> aldre = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };

            foreach (int isaldre in aldre)
            {
                Console.WriteLine(isaldre);
            }
            aldre.Remove(13);
            Console.WriteLine("remove:");
            foreach (int isaldre in aldre)
            {
                Console.WriteLine(isaldre);
            }
            aldre.RemoveAt(3);
            Console.WriteLine("remove at:");
            foreach (int isaldre in aldre)
            {
                Console.WriteLine(isaldre);
            }
            Console.WriteLine(navne[0]);

            //Console.ReadLine();
        }
    }
}
