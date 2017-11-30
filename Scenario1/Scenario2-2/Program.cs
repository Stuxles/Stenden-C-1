using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("x:");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("y:");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("z:");
            z = Int32.Parse(Console.ReadLine());
            Location l = new Location(x, y, z);
            Console.WriteLine("Location = x:{0}, y:{1}, z:{2}", l.x, l.y, l.z);
        }
    }
}
