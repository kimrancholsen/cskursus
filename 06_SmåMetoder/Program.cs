using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SmåMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pkt. 1
            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            //Pkt. 2
            double areal = BeregnAreal(5);
            Console.WriteLine(areal);

            //Pkt. 3
            Udskriv("Dette er en test");
            Udskriv();

            //Pkt. 4
            double medPct = BeregnMoms(100.35, 0.25);
            Console.WriteLine(medPct.ToString());

            double udenPct = BeregnMoms(100.35);
            Console.WriteLine(udenPct.ToString());

            //Pkt. 5
            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);

        }


        //Pkt. 1
        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        //Pkt. 2
        static double BeregnAreal(int radius)
        {
            return (radius * radius * Math.PI);
        }

        //Pkt. 3
        static void Udskriv(string text = " ")
        {
            Console.WriteLine(text);
        }

        //Pkt. 4
        static double BeregnMoms(double beløb, double momsPct = 0.25)
        {
            return beløb * momsPct;
        }

        //Pkt. 5
        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }

            double gns = sum / månedsløn.Length;
            return gns;

        }
    }


}
