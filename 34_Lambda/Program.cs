using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine(a.FindIndex(Find));
            Console.WriteLine();
            Console.WriteLine(a.FindIndex((i) => { return i == 51; }));
            Console.WriteLine();
            Console.WriteLine(a.FindIndex(i => i == 51));


            Console.WriteLine("****");
            a.ForEach(ListVærdi);
            Console.WriteLine("....");
            a.ForEach((i) => { Console.WriteLine(i); });
            Console.WriteLine("----");
            a.ForEach((i) => Console.WriteLine(i));






        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(": " + i);
        }

        static bool Find(int i)
        {
            return i == 51;
        }
    }
}
