using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    enum FilTyper
    {
        csv, pdf, txt

    }

    struct Person
    {
        public int Id;
        public string Navn;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Pkt. 1
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal.ToString());

            //Pkt. 2
            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal.ToString());

            //Pkt. 3 - enum defineret under namespace

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            int r = (int)ft;
            Console.WriteLine(r);

            //Pkt. 4
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));
            Console.WriteLine(dt.ToString("f"));
            Console.WriteLine(dt.ToString("s"));

            //Pkt. 5
            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn.ToString());





        }
    }
}
