using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int fact = 1;
            while (n > 1)
            {
                fact = fact * n;
                n = n - 1;
            }
            Console.WriteLine(fact);
        }
    }
}
