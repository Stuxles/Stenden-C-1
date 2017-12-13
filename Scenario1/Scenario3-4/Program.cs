using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = {"bananen", "appels", "peren", "druiven", "komkommer"};
            LinkedList<string> list = new LinkedList<string>(words);
            
            Console.WriteLine("Product:");
            String search = Console.ReadLine();
            if (list.Contains(search))
            {
                Console.WriteLine("lijst bevat item");
            }
            else
            {
                Console.WriteLine("item niet gevonden");
            }
        }
    }
}
