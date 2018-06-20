using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_DelegateFunkPointer3
{

    class Program
    {

        //public delegate int DelegateBeregn(int x, int y);

        static void Main(string[] args)
        {
            int res1 = Beregner(10, 6, funktion: FindTilfældigFunktion() );
            Console.WriteLine(res1.ToString());

            int res2 = Beregner(100, 44, Minus);
            Console.WriteLine(res2.ToString());

            //int res3 = Beregner(3, 3, Gange);
            //Console.WriteLine(res3.ToString());

        }


        public static Func<int, int, int> FindTilfældigFunktion()
        {
            if (DateTime.Now.Millisecond <= 250)
                return Plus;
            if (DateTime.Now.Millisecond <= 500)
                return Minus;
            if (DateTime.Now.Millisecond <= 750)
                return Divider;
            return Gange;
                       
        }

        public static int Beregner(int d, int e, Func<int, int, int> funktion)
        {
            return funktion(d, e);
        }


        //regnefunktioner
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
