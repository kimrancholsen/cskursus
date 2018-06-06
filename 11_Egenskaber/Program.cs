using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare("vare #1", 100);
            v.Navn = "vare #1";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());

        }
    }

    public class Vare
    {


        public Vare(string navn, double pris)
        {
            _navn = navn;
            _pris = pris;
        }

        private string _navn;
        public string Navn
        {
            get {
                Console.WriteLine("Nu aflæses navn");
                return _navn; }
            set {
                Console.WriteLine("Nu tildeles navn");
                _navn = value; }
        }

        private double _pris;
        private double res;



        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses pris");
                return _pris; }
            set {
                Console.WriteLine("Nu tildeles pris");
                _pris = value; }
        }

    public double  PrisMedMoms()
        {
            return this.Pris * 1.25;
        }


    }
}
