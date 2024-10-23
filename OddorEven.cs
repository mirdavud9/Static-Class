using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class__Extensions_methods
{
    public static class IsOddEvenChecker
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;  
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;  
        }
    }
}
