using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class__Extensions_methods
{

        public static class PasswordChecker
        {
            public static bool CheckPassword(this string password)
            {
                if (password.Length < 8) return false;

                bool hasUpper = false, hasLower = false, hasDigit = false;

                foreach (char c in password)
                {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsDigit(c))
                    hasDigit = true;

                if (hasUpper && hasLower && hasDigit)
                    break;
                if (hasUpper && hasLower && hasDigit) return true;
                }

                return false;
            }
        }

    }

