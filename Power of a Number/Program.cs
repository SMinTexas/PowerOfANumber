using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Of_A_Number
{
    class Program
    {
        internal static double Power(double @base, int exponent)
        {
            if (exponent < 0)
            {
                Console.Error.WriteLine("Usage of this function is limited to positive exponents");
                throw new Exception();
            }
            else if (exponent == 1)
            {
                return @base;
            }
            else if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return @base * Power(@base, exponent - 1);
            }
        }
        static void Main(string[] args)
        {
            double x = Power(10, 4);
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
