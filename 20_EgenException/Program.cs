using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_EgenException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockItem st = new StockItem(-3);
            }
            catch (StockItemException e)
            {
                Console.WriteLine("StockItem error: " + e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("General error");

            }
        }
    }

    public class StockItem
    {
        public int Id { get; set; }

        //default constructor
        public StockItem()
        {

        }
        //custom constructor
        public StockItem(int idinput)
        {
            if (idinput < 0)
                throw new StockItemException("Wrong id");
        }


    }
    public class StockItemException : Exception
    {

        public StockItemException(string message) : base(message)
        {

        }
    }


}
