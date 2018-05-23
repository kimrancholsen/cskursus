using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            int[] a1;
            a1 = new int[5];

            int[] a2 = new int[5];

            a1[0] = 10;
            a1[4] = 100;

            a2 = a1;

            //strenge
            char t = 'A'; //char = enkelt karakter
            string navn = "Kim";
            navn = navn.ToUpper(); // Laver en ny streng variabel. Den oprindelige streng ændres ikke

            string sti = @"c:\temp\test.txt";

            Console.WriteLine(sti);

            //csv assembly
            string csv = "423;334;343;";
            string[] aa = csv.Split(';');

            // c# version 7
            int alder = 20;
            string person = "Kim";
            string tekst = $"Personen {person} er {alder} år.";

            //tilføje tekst til en streng over flere iterationer

            System.Text.StringBuilder sb = new StringBuilder();
            for (int i = 0;i<100_000; i++)
            {
                sb.Append("*");
            }


       
        }
    }
}
