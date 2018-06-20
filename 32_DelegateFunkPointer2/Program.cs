using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DelegateFunkPointer2
{


    class Program
    {

        //public delegate int DelegateBeregn(int x, int y);

        static void Main(string[] args)
        {
            int res1 = Beregner(5, 6, Plus);
            Console.WriteLine(res1.ToString());

            int res2 = Beregner(100, 44, Minus);
            Console.WriteLine(res2.ToString());

            int res3 = Beregner(3, 3, Gange);
            Console.WriteLine(res3.ToString());

        }


        public static int Beregner(int d, int e, Func<int, int, int> funktion)
        {
            return funktion(d, e);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}

