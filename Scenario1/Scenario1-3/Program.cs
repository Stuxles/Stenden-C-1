using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_3
{
    class Program
    {
//        You are writing code for a simple arithmetic library.You decide to create a method named
//        Divide that takes two arguments, x and y, and returns the value of x/y.You need to catch
//        any arithmetic exceptions that might be thrown for errors in arithmetic, casting, or data type
//        conversions. You also need to catch any other exceptions that may be thrown from the code.
//        To address this requirement, you need to create properly structured exception-handling code.
//        How would you write such a program?
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(3, 3));
        }

        public static double Divide(double x, double y)
        {
            double result = 0;
            try
            {
                result = x / y;
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
                throw;
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice.Message);
                throw;
            }
            catch (DataException de)
            {
                Console.WriteLine(de.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return result;
        }
    }
}
