using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EgenskaberTrekant
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant t1 = new Trekant();
            Console.WriteLine(t1.Areal);

            Trekant t2 = new Trekant(5,10);
            Console.WriteLine(t2.Areal);

        }
    }

    public class Trekant
    {

        private int _grundlinje;

        public int Grundlinje
        {
            get { return _grundlinje; }
            private set { _grundlinje = value; }
        }

        private int _højde;

        public int Højde
        {
            get { return _højde; }
            private set { _højde = value; }
        }

        //default constructor
        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        //custom constructor
        public Trekant()
        {
            this.Grundlinje = 3;
            this.Højde = 2;
        }

        public double Areal
        {
            get { return this.Grundlinje * this.Højde * 0.5; }
            
        }

    }
}
