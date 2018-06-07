using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person
            Person p1 = new Person();
            p1.Fornavn = "Kim";
            p1.Efternavn = "Olsen";
            Console.WriteLine(p1.FuldtNavn());

            //Elev
            Elev e1 = new Elev();
            e1.Fornavn = "Lære";
            e1.Efternavn = "Nem";
            Console.WriteLine(e1.FuldtNavn());

            //Instruktør
            Instruktør i1 = new Instruktør();
            i1.Fornavn = "Svend";
            i1.Efternavn = "Spanskrør";
            Console.WriteLine(i1.FuldtNavn());

        }

        public class Person
        {
            public string Fornavn { get; set; }
            public string Efternavn { get; set; }

            public string FuldtNavn()
            {
                return this.Fornavn + " " + this.Efternavn;
            }

        }

        public class Elev : Person
        {
            public string Klasselokale { get; set; }

        }

        public class Instruktør : Person
        {
            public int NøgleId { get; set; }
        }

    }
}
