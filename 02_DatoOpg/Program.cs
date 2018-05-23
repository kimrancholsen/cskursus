using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DatoOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alle punkter
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.ToString());

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1.ToString());

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1.ToString());

            DateTime d2 = DateTime.Now;
            DateTime d3 = DateTime.Now;
            d3 = d3.AddDays(10);
            TimeSpan diff1 = d3.Subtract(d2);
            Console.WriteLine(diff1.ToString());

            TimeSpan t2;
            t2 = new TimeSpan(0, 16, 0, 0);
            Console.WriteLine(t2);

            TimeSpan t3;
            t3 = new TimeSpan(0, 0, 30, 0);
            Console.WriteLine(t3);

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);




        }
    }
}
