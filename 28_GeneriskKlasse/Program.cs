using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_GeneriskKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Personer1 pliste = new Personer1();
            pliste.Tilføj(new Kursist());
            //            Kursist k1 = new Kursist { Navn = "Kim", KursistId = 3543 };
            Console.WriteLine(pliste.ToString());   
        }
    }


    class Personer1
    {
        List<Person> typeList = new List<Person>();

        public void Tilføj(Person p)
        {
            typeList.Add(p);
        }
    }

    class Personer2<T>
    {
        List<T> genericList = new List<T>();

        public void Tilføj(T p)
        {
            genericList.Add(p);
        }

    }
    class Person
    {
        public string Navn { get; set; }
    }

    class Kursist : Person
    {
        public int KursistId { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
