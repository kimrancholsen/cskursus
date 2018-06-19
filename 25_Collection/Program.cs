using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> personliste = new List<Person>();
            personliste.Add(item: new Person { Id = 1, Navn = "Kim" });
            personliste.Add(item: new Person { Id = 2, Navn = "Rolf" });
            personliste.Add(item: new Person { Id = 3, Navn = "Jacob" });
            foreach (var item in personliste)
            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> liste2 = new Dictionary<int, Person>();
            Person value = new Person { Id = 3, Navn = "Jan" };
            liste2.Add(123, value);
            Person value2 = new Person { Id = 4, Navn = "Simon" };
            liste2.Add(122, value2);
            Person value3 = new Person { Id = 5, Navn = "Kasper" };
            liste2.Add(124, value3);

            var v = liste2[122];

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }    
    }
}
