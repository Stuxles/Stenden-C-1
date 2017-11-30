using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ISampleEvents se = new SampleClass();

            se.SampleEvent += new SampleDelegate(TestHandler);
            se.Invoke();
        }

        static private void TestHandler()
        {
            Console.WriteLine("Testevent");
        }
    }
}
