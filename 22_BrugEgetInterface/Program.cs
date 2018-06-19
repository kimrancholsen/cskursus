using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_BrugEgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] a = new IDbFunktioner[4];
            a[0] = new Hund();
            a[1] = new Ubåd();
            a[2] = new Ubåd();
            a[3] = new Hund();

            foreach (IDbFunktioner item in a)
            {
                item.Gem();
            }
        }


        class Hund : IDbFunktioner
        {
            public string Navn { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer hund");
            }
        }

        class Ubåd : IDbFunktioner
        {
            public int Nummer { get; set; }
            public double Turbine { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer ubåd");
            }
        }

        interface IDbFunktioner
        {
            void Gem();
        }
    }
}
