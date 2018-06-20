using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Delegates
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Maskine m1 = new Maskine();
            m1.Log = Console.WriteLine;
            m1.Log += AppendLog;
            m1.Start();
            m1.Stop();
            
        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
    }

    public delegate void LogDelegate(string txt);
    class Maskine
    {

        public LogDelegate Log { get; set; }

        public void Start()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString() + " " +  "Starter");
        }

        public void Stop()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString() + " " + "Stopper");
        }

    }


}
