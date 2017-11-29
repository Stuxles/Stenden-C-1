using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product: ");
            string name = Console.ReadLine();
            Console.WriteLine("Price:");
            double price = Double.Parse(Console.ReadLine());

            Product p = new Product(name, price);
            Console.WriteLine(p.ToString());
        }
    }
}
