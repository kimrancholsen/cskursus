using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_GeneriskMetode
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            //Swap<int>(ref a, ref b);
            Swap(ref a, ref b);

            string x = "Kim";
            string y = "Mette";
            //Swap<string>(ref x, ref y);
            Swap(ref x, ref y);


        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
