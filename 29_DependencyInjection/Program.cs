using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
            Console.WriteLine(m.FindTalTilTerning());
            ITilfældighedsGenerator k = new TilfældighedsGeneratorFramework();
            Console.WriteLine(k.FindTalTilTerning());

        }
    }


    class Terning
    {
        public int Værdi { get; set; }
        private ITilfældighedsGenerator generator;
        

        public Terning(ITilfældighedsGenerator rnd)
        {
            generator = rnd;
            Ryst();

        }

        public void Ryst()
        {
            this.Værdi = generator.FindTalTilTerning();
        }

    }
    public interface ITilfældighedsGenerator
    {
        int FindTalTilTerning();

    }

    class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static System.Random rnd = new System.Random();
        public int FindTalTilTerning()
        {
            return rnd.Next(1, 7);
        }
        

    }

    class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        private int tal;
        public TilfældighedsGeneratorMock(int t)
        {
            this.tal = t;
        }
        public int FindTalTilTerning()
        {
            return this.tal;
        }
    }
}
