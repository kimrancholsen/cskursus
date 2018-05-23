using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[5];

            int[] a2 = new int[5];

            a1[0] = 10;
            a1[4] = 100;

            a2 = a1;

           
        }
    }
}
