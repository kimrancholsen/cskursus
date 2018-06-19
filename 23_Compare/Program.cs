using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            Array.Sort(hunde);
            foreach (Hund item in hunde)
            {
                Console.WriteLine(item.Navn);
                
            }

            //forsøg - ikke med i opg.
            Hund[] kennel = new Hund[3];


        }
    }

    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        //sortering på alder, ascending
        public int CompareTo(object obj)
        {
            Hund h2 = obj as Hund;
            if (this.Alder < h2.Alder)
            {
                return -1;
            }
            if (this.Alder > h2.Alder)
            {
                return 1;
            }
            return 0;
        }

        //forsøg - ikke med i opg.
        public class SammenlignHundenavn : IComparer
        {
            public int Compare(object x, object y)
            {
                Hund h1 = x as Hund;
                Hund h2 = y as Hund;
                return String.Compare(h1.Navn, h2.Navn);
            }
        }


    }
}
