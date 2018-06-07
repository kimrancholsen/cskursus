using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ArvRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                UdvidetRandom u = new UdvidetRandom();
                Console.WriteLine(u.NextBool());
            }

        }
    }

    public class UdvidetRandom : System.Random
    {
        Random rnd = new Random();
        private bool b;

        public bool NextBool()
        {
            if(rnd.Next(1, 1002) < 500)
               return true;
            return false;
        }

    }
}
