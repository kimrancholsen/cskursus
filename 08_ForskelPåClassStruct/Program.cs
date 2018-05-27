using System;

namespace _08_ForskelPåClassStruct
{
    class Program
    {

        static void Main(string[] args)
        {
            Person k1 = new Person();
            Person k2 = new Person();

            k1.navn = "a";
            k2.navn = "b";

            Console.WriteLine(k1.navn.ToString());
            Console.WriteLine(k2.navn.ToString());
            k1 = k2;
            Console.WriteLine(k1.navn.ToString());
            Console.WriteLine(k2.navn.ToString());

            k1.navn = "c";
            Console.WriteLine(k1.navn.ToString());
            Console.WriteLine(k2.navn.ToString());
            // Udskriver ab, bb, cb - Der kopieres værdier til de to instanser af struct'en
            // Der rettes fra struct til class og der udskrives ab, bb, cc
            // k1 sættes til at pege på samme reference som k2 i HEAP'en og de peger dermed på samme reference. Den tidligere reference fra
            // k1 til Person, slettes af garbage collect'eren.
        }
    }
    class Person

    {
        public string navn;
    }
}
