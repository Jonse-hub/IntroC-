using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20StreamReader
{
    class Person
    {
        string fornavn = "";
        string efternavn = "";
        byte alder = 0;

        public string Fornavn { get => fornavn; set => fornavn = value; }
        public string Efternavn { get => efternavn; set => efternavn = value; }
        public byte Alder { get => alder; set => alder = value; }

        public Person(string fornavn, string efternavn, byte alder)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Alder = Convert.ToByte(alder);
        }
        public override string ToString()
        {
            return $"{Fornavn} {Efternavn} {Alder}";
            //return base.ToString();
        }

        public void PrintInfo()
        {
            Console.WriteLine("fornavn: " + Fornavn+", efternavn: "+ Efternavn+", alder: "+ Alder);
        }

        /*public override string ToString()
        {
            return base.ToString();
        }*/


        void ældst()
        {
        }
    }
}
