using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Fornavn = "kim";
            p1.Efternavn = "olsen";
            Console.WriteLine("Person p1 navn:" + p1.FuldtNavn());

            Person p2 = new Person("freja", "olsen");
            p2.Alder();
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Fødselsår);

            p2.Fødselsår = 2003;
            Console.WriteLine(p2.Alder()); 
            

        }
    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        //default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        //custosm constructor
        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();
            this.Fødselsår = System.DateTime.Now.Year;


        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            int alder = System.DateTime.Now.Year - this.Fødselsår;
            return alder;

        }
    }
}
