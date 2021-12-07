using System;

namespace Labb_5_Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckChild1<int> obj1 = new CheckChild1<int>();
            CheckChild1<string> obj2 = new CheckChild1<string>();

            CheckChild2<double> obj3 = new CheckChild2<double>();
            CheckChild2<bool> obj4 = new CheckChild2<bool>();

            obj1.toCheck(10, 10);
            obj2.toCheck("Hello", "Hello");
            obj3.toCheck(10.255, 12.343);
            obj4.toCheck(true, false);
        }
    }
}
