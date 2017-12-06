using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[,]
            {
                {11, 7, 25, 74, 30},
                {99, 3, 42, 21, 23},
                {17, 54, 32, 65, 21},
                {53, 86, 43, 47, 35}
            };

            for (int j = 0; j < numbers.GetLength(0); j++)
            {
                for (int i = 0; i < numbers.GetLength(1); i++)
                {
                    Console.WriteLine(numbers[j, i]);
                }
                Console.WriteLine("test");
            }
        }
    }
}
