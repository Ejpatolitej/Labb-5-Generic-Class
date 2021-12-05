using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_5_Generic_Class
{
    public class Check
    {
        public bool toCheck<T>(T var1, T var2)
        {
            if (var1.Equals(var2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
