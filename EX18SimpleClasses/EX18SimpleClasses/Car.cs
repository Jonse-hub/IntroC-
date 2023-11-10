using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EX18SimpleClasses
{
    class Car
    {
        string make = "";
        string model = "";
        string color = "";
        int price = 0;
        bool isSold = false;
        bool isOnSale = false;
        List<Car> cars = new List<Car>();
        // Car car = new Car("");

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }
        public bool IsSold { get => isSold; set => isSold = value; }
        public bool IsOnSale { get => isOnSale; set => isOnSale = value; }
        internal List<Car> Cars { get => cars; set => cars = value; }

        public void PrintInfo()
        {
            if (isSold == false)
            {
                if (isOnSale == false) { 
                Console.WriteLine("Bilen er en " + Make + " " + Model + "i farven" + Color + ". Prisen er " + Price + " DKK");
                }
                else if (isOnSale == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Denne bil er til salg! - "+"Bilen er en " + Make + " " + Model + "i farven" + Color + ". Prisen er " + Price + " DKK");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (isSold == true)
            {
                Console.WriteLine("SOLGT! Bilen er en " + Make + " " + Model + "i farven" + Color + ". Prisen er " + Price + " DKK");

            }
            

        }
        // old make of car
        public Car(string make, string model, string color, int price, bool isSold)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }
        public override string ToString()
        {
            return $"{Make} {Model}";
            //return base.ToString();
        }

        public void PutOnSale()
        {
            IsOnSale = true;
            Price = Convert.ToInt32(price * 0.9);
        }

        public Car(string csv)
        {
            Car mycar = new Car("honda", "he", "yellow", 2002, false);
            // Split the csv data
            // Car i = new Car(Make, Model, Color, Price, false);
            using (StreamReader reader = new StreamReader(new FileStream(csv, FileMode.Open)))
            {
                string line;
                while (reader.EndOfStream != true)
                {
                    line = reader.ReadLine();

                    string[] array = line.Split(',');

                    // Save the splitted data in the correct property
                    mycar = new Car(array[0], array[1], array[2], Convert.ToInt32(array[3]), Convert.ToBoolean(array[4]));

                    cars.Add(mycar);

                    // Cars.Add(i); 
                }
            }





            // File.WriteAllText(@"C:\Users\jona444j\source\repos\EX18SimpleClasses\EX18SimpleClasses\hej.txt", csv); //Convert.ToString(Program.myCar)
        }
        public string CreateCsv()
        {

            // Take all the data from the porperties
            // and concatenate them in one comma separated string
            // string csv = File.ReadAllText(@"C:\Users\jona444j\source\repos\EX18SimpleClasses\EX18SimpleClasses\hej.txt");
            string line = "";

            using (StreamWriter writer = new StreamWriter(@"C:\Users\jona444j\source\repos\EX18SimpleClasses\EX18SimpleClasses\csv.txt", true))
            {

                /*foreach (Car c in Cars) {*/
                line = ($"{Make}, {Model}, {Color}, {Price}, {isSold}");
                writer.WriteLine(line); // is on sale??, ikke før not on sale.
                                        //  }

            }
            return line;

            //throw new NotImplementedException();
        }

    }
}
