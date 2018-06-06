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

        private int _værdi;

        //default constructor
        public Terning()
        {
        }

        public int Værdi
        {
            get { return _værdi; }
            set
            {
                if (value < 1 || value > 6)
                { value = 1; }
                else
                {
                    _værdi = value;
                }
            }
        }

    }
}
