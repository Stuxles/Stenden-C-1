using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.Write("Enter name:");
            try
            {
                p.Name = Console.ReadLine();
                Console.WriteLine("The name is: {0}", p.Name);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae);
            }
        }
    }
}
