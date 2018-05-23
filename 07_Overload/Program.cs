using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1,2,3));
            Console.WriteLine(Beregn(1,2,4,5));
        }

        static int Beregn(int a, int b)
        {
            int res = 0;
            return res = a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            int res = 0;
            return res = a + b + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            int res = 0;
            return res = a + b + c + d;
        }
    }
}
