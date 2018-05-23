using System;


namespace TestApplikation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            //simple variabler
            System.Int32 i = 1;
            string s = i.ToString();
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            int ii;
            ii = 100;

            System.Boolean b = true;
            bool bb = false;

            //kommatal
            double d;
            System.Double dd;
            d = 74.939838398;
            Console.WriteLine(d.ToString("F4"));

            //date
            System.DateTime da;
            da = System.DateTime.Now;
            Console.WriteLine(da.ToString("yyyy-MM"));


            //timespan
            System.DateTime d1 = System.DateTime.Now;
            System.DateTime d2 = new DateTime(2018, 12, 24);
            System.TimeSpan ts = d2.Subtract(d1);
            Console.WriteLine(ts.ToString());
            Console.WriteLine(ts.TotalDays.ToString());

            //konstanter
            const double momsPct = 0.25; //bør defineres i en fil eller db
            Console.WriteLine(momsPct.ToString());

            //modulus

            // ************************************************************
            // Summering
            // ************************************************************



        }
}
