using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_StatiskeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkat(10,10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
        }
    }

    static class ArealBeregninger
    {


        public static double BeregnArealFirkat(double højde, double bredde)
        {

            return højde * bredde;

        }

        public static double BeregnArealCirkel(double radius)
        {
            return System.Math.PI * System.Math.Pow(radius,2);
        }

    }
}
