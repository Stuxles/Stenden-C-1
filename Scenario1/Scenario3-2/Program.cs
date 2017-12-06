using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue first = new Queue();
            first.Enqueue(4);
            first.Enqueue(20);
            first.Enqueue(32);
            first.Enqueue(45);

            Queue second = new Queue();
            second.Enqueue(9);
            second.Enqueue(14);
            second.Enqueue(34);
            second.Enqueue(66);

            ProcessQueue(first, second);
        }

        static void ProcessQueue(Queue first, Queue second)
        {
            while (first.Count < 0 || second.Count < 0)
            {
                if ((int)first.Peek() >= (int)second.Peek())
                {
                    
                }
            }
        }
    }
}
