using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = efternavn.Substring(0, 4);
            Console.WriteLine(del);

            string[] myStringArray = samletNavn.Split(' ');

            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(myStringArray[i]);

            }



        }
    }
}
