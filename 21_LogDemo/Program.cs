using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;


namespace _21_LogDemo
{
    class Program
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            //opgaven er ikke lavet færdig. Kommet til "Tilføj nu kald til logger.Trace"
            test1(5, 5);
            test2();

        }

        static void test1(int i, int x)
        {
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
        }

        static void test2()
        {
            try
            {
                System.Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                //mangler log
            }
        }
    }
}
