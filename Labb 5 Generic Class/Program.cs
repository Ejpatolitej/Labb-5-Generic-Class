using System;

namespace Labb_5_Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckChild1 obj1 = new CheckChild1();
            CheckChild1 obj2 = new CheckChild1();

            CheckChild2 obj3 = new CheckChild2();
            CheckChild2 obj4 = new CheckChild2();

            obj1.toCheck(10, 10);
            obj2.toCheck("Hello", "Hello");
            obj3.toCheck(10.255, 12.343);
            obj4.toCheck(true, false);
        }
    }
}
