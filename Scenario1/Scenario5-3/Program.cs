using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert text:");
            String text = Console.ReadLine();
            if (text != null)
            {
                String upper = text.ToUpper();
                Console.WriteLine(upper);
            }
        }
    }
}
