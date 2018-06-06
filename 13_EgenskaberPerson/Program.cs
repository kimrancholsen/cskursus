using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EgenskaberPerson
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Fornavn = "kim";
            p1.Efternavn = "bo";
            Console.WriteLine(p1.FuldtNavn());

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
            set {
                if (value.Length < 4)
                {
                    _efternavn = "";
                }
                else {
                    _efternavn = value;
                }

 }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

    }


}
