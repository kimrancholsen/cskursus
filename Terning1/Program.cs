using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning1
{
    class Program
    {
        static void Main(string[] args)
        {

            // prompten bliver åben og venter på tastetryk under debug
            Console.ReadKey();
        }
    }

    public class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            værdi = 1;
            snyd = false;
        }

        public Terning(bool snyd)
        {
            værdi = 1;
            this.snyd = true;
        }

    }
}
