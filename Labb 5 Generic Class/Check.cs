using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_5_Generic_Class
{
    public class Check <T>
    {
        public void toCheck(T var1, T var2)
        {
            if (var1.Equals(var2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
