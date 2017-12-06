using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack first = new Stack();
            first.Push(87);
            first.Push(75);
            first.Push(54);
            first.Push(32);
            first.Push(12);

            Stack second = new Stack();
            second.Push(98);
            second.Push(76);
            second.Push(65);
            second.Push(43);
            second.Push(2);

            ProcessStack(first, second);
        }

        static void ProcessStack(Stack first, Stack second)
        {
            while (first.Count > 0 || second.Count > 0)
            {
                if (first.Count == 0)
                {
                    Console.WriteLine(second.Pop());
                    continue;
                }
                if (second.Count == 0)
                {
                    Console.WriteLine(first.Pop());
                    continue;
                }

                if ((int)first.Peek() >= (int)second.Peek())
                {
                    Console.WriteLine(second.Pop());
                }
                else
                {
                    Console.WriteLine(first.Pop());
                }
            }
        }
    }
}
