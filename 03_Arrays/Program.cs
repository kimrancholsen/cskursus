using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salaryArray = { 10000, 20000, 15000, 20000, 30000, 15000 };

            //foreach
            foreach (int i in salaryArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Genemsnit " + salaryArray.Average());

            //for løkke
            double sum = 0;
            for (int i = 0; i < salaryArray.Length; i++)
            {
                sum += salaryArray[i];
            }

            double gns = sum / salaryArray.Length;
            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));

            //sort
            System.Array.Sort(salaryArray);
            foreach (int i in salaryArray)
            {
                Console.WriteLine(i);
            }

            //reverse
            System.Array.Reverse(salaryArray);
            Console.WriteLine("Reverted");
            foreach (int i in salaryArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
