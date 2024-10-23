using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class__Extensions_methods
{
    public static class HasDigitChecker
    {
        public static bool HasDigit(this string value)
        {
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    return true; 
                }
            }
            return true;
        }
    }
}
