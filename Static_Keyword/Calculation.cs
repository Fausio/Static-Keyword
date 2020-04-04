using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Keyword
{
    static class Calculation
    {
        public static void add(double FistNumber, double SecundNumber)
        {
            Console.WriteLine("Additin of {0} and {1} is {2}", FistNumber, SecundNumber, (FistNumber + SecundNumber));
        }
        public static void Sub(double FistNumber, double SecundNumber)
        {
            Console.WriteLine("subtraction of {0} and {1} is {2}", FistNumber, SecundNumber, (FistNumber - SecundNumber));
        }
    }
}
 