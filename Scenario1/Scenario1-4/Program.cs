using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_4
{
    class Program
    {
//        You are developing a library of utility functions for your application.You need to write a
//        method that takes an integer and counts the number of significant digits in it.You need to
//        create a recursive program to solve this problem.How would you write such a program?
        static void Main(string[] args)
        {
            Console.WriteLine(Recur(1234567));
        }
        
        public static int Recur(int x)
        {
            if (x / 10 == 0)
            {
                return 1;
            }
            else
            {
                return 1 + Recur(x / 10);
            }
            
        }
    }
}
