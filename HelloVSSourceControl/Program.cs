using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVSSourceControl
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the store!");
            DisplayInStockItems();
            Console.WriteLine("Press a key to end");
            Console.ReadKey();
        }

        /// <summary>
        /// Displays a list of in stock items, in alphabetical order.
        /// </summary>
        static void DisplayInStockItems()
        {
            //Not pulling from an actual database.
            List<string> cars = new List<string>
            {
                "Honda Preluda - Qty: 5",
                "Nissan Sentra - Qty: 4"
            };

            foreach(string currCar in cars)
            {
                Console.WriteLine(currCar);
            }
        }
    }
}
