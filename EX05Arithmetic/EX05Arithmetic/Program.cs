using System;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            byte tæller = 1;
            string stringtæller = Convert.ToString(tæller);
            Console.WriteLine("Velkommen til lommeregneren\nKan plus, minus, gange, division og modulo");
            Console.Write("indtast et tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("indtast et andet tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            int i = 1;
            double Resultat = tal1 + tal2;
            double Resultat2 = tal1 - tal2;
            double Resultat3 = tal1 * tal2;
            double Resultat4 = tal1 / tal2;
            double Resultat5 = tal1 % tal2;
        back:
            Console.Write("fortsæt?(y/N) ");
            string fortsæt = Console.ReadLine().ToLower();
            
            if (fortsæt == "y"){
                Console.Write("indtast et andet tal: ");
                tal2 = Convert.ToDouble(Console.ReadLine());
                Resultat = Resultat+ tal2;
                Resultat2 = Resultat2 - tal2;
                Resultat3 = Resultat3 * tal2;
                Resultat4 = Resultat4 / tal2;
                Resultat5 = Resultat5 % tal2;

                i = i + 1;
                goto back; // goto er måske dårligt så..

            }
            else if (fortsæt == "n") {
                Console.WriteLine($"plus: {Resultat}");
                Console.WriteLine($"minus: {Resultat2}");
                Console.WriteLine($"gange: {Resultat3}");
                Console.WriteLine($"dividere: {Resultat4}");
                Console.WriteLine($"modulo: {Resultat5}");
            }
            else
            {
                goto back;
            }

            
        }
    }
}
