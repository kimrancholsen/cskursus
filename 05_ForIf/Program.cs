using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ForIf
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 11; i++)
            {
                for (int x = 1; x < 11; x++)
                {
                    string res = (i * x).ToString();
                    if ((i * x) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        else
                        Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.Write(res.PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
