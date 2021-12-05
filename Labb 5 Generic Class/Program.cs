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

            bool result1 = obj1.toCheck(10, 10);
            if (result1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            bool result2 = obj2.toCheck("Hello", "Hello");
            if (result2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            bool result3 = obj3.toCheck(10.255, 12.343);
            if (result3)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            bool result4 = obj4.toCheck(true, false);
            if (result4)
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
