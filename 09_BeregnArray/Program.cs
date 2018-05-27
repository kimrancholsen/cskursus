using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {10, 7, 6, 3, 1, 50, 3};
            var res = BeregnOgSorterArray(test);
        }

        public static ArrayResultat BeregnOgSorterArray(int[] intarray)
        {

            ArrayResultat r;
            r.sum = 0;

            for (int i = 0; i < intarray.Length; i++)
            {
                r.sum += intarray[i];
            }

            r.gennemsnit = r.sum / intarray.Length;

            System.Array.Sort(intarray);

            return r;


        }
    }


    struct ArrayResultat
    {
        public double sum;
        public double gennemsnit;
    }

}
