using System;
using System.Collections.Generic;
using System.Text;

namespace EX20StreamReader
{
    class Box
    {
        byte height = 40;
        byte Length = 60;
        byte Width = 20;
        int Volume = 0;
        int Surface = 0;

        public byte Height { get => height; set => height = value; }
        public byte Length1 { get => Length; set => Length = value; }
        public byte Width1 { get => Width; set => Width = value; }
        private int Surface1 { get => Surface; set => Surface = value; }
        private int Volume1 { get => Volume; set => Volume = value; }


        public Box(int height, int Length, int Width)
        {
            Height = Convert.ToByte(height);
            Length1 = Convert.ToByte(Length);
            Width1 = Convert.ToByte(Width);
        }

        // int result = 0;
        public void CalculateVolume()
        {
            Volume = height * Length;
        }

        public void CalculateSurface()
        {
            Surface = height * Length * Width;
        }


            public void PrintInfo()
        {
            Console.WriteLine(Height + "x" + Length1 + "x" + Width1);
            Console.WriteLine("rumfang= "+ Volume1);
            Console.WriteLine("overfladeareal: "+ Surface1);
        }


    }

    
}
