using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;
            if (number < 10)
            {
                Console.WriteLine("5%");
            }
            else if (number < 50)
            {
                Console.WriteLine("10%");
            }
            else if (number < 100)
            {
                Console.WriteLine("15%");
            }
            else
            {
                Console.WriteLine("20%");
            }
        }
    }
}
