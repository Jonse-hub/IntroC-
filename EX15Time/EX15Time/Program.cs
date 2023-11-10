using System;

namespace EX15Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now);
            //Console.WriteLine(now.TimeOfDay);
            /*string value2 = "12/24/2020";
            var date2 = DateTime.Parse(value2); */
            var date = DateTime.Parse("18:00:00 24/12");
            var difference = date.Subtract(now);
            Console.WriteLine(difference.GetType());

            // Console.WriteLine("DAYS DIFFERENCE: {0}", difference.TotalDays);

            Console.WriteLine("dage: "+difference.Days);
            Console.WriteLine("timer: "+ difference.Hours);
            Console.WriteLine("minuter: " + difference.Minutes);

            Console.Write("indtast dag/måned/årstal, vil vise dig hvor lang tid der er til: ");
            var tiden = DateTime.Parse(Console.ReadLine());
            difference = tiden.Subtract(now);

            // var differencedatetime = DateTime.Parse(difference);
            /*if (difference.Days > 356) // over et år viser et år. men kan ikke nemt i timespan + kan ikke konverteres til DateTime..
            {

                Console.WriteLine(difference);
            }*/

            Console.WriteLine("dage: " + difference.Days);
            Console.WriteLine("timer: " + difference.Hours);
            Console.WriteLine("minuter: " + difference.Minutes);
        }
    }
}
