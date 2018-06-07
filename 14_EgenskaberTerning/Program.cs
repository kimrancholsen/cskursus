using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_EgenskaberTerning
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }

    public class Terning
    {

        private static Random rnd = new Random();
        private int _værdi;

        //default constructor
        public Terning()
        {
            this.Ryst();
        }

        public Terning(int startværdi)
        {
            this.Værdi = startværdi;
        }

        public int Værdi
        {
            get {
                Console.WriteLine("Der aflæses værdi " + this._værdi);
                return _værdi; }
            set
            {
                if (value < 1 || value > 6)
                { value = 1; }
                else
                {
                    Console.WriteLine("Der tildeles værdi " + value);
                    this._værdi = value;
                }
            }
        }

        public int Ryst()
        {
            return rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine(" + this._værdi. + ");
        }

    }
}
