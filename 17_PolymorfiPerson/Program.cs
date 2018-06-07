using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PolymorfiPerson
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Fornavn = "Per";
            p.Efternavn = "Sonata";
            //Console.WriteLine(p.Skriv());

            Elev e = new Elev();
            e.Fornavn = "Erling";
            e.Efternavn = "Grand";
            e.Klasselokale = "3a";
            //Console.WriteLine(e.Skriv());

            Instruktør i = new Instruktør();
            i.Fornavn = "Ib";
            i.Efternavn = "Olsen";
            i.NøgleId = 4;
            //Console.WriteLine(i.Skriv());

            //Array af personer
            Person[] a = new Person[3];
            a[0] = p;
            a[1] = e;
            a[2] = i;

            foreach (var item in a)
            {
                item.Skriv();
            }

        }
    }

    public class Person
    {
        //default constructor
        public Person()
        {
            //this._efternavn = "";
        }

        public string Fornavn { get; set; }

        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                if (value.Length < 4)
                {
                    _efternavn = "";
                }
                else
                {
                    _efternavn = value;
                }

            }
        }

        public virtual void Skriv()
        {
            Console.WriteLine($"{Fornavn } { Efternavn}");
        }

    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine($"{ Fornavn} { Efternavn} { Klasselokale}");
        }
    } 

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

        public override void Skriv()
        {
            Console.WriteLine($"{ Fornavn} { Efternavn} { NøgleId}");
        }
    }
}
