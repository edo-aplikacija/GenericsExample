using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing and unboxing will hapend
            //bool equal = Calculator.AreEqual("A", "A");

            // boxing and unboxing will not happend
            // and now is again type safe method and must use same types for value1 and value2
            // will work also
            //bool equal = Calculator.AreEqual("A", "a");
            // will not work
            //bool equal = Calculator.AreEqual("A", 1);
            bool equal = Calculator.AreEqual<string>("A", "a");
            bool equal2 = Calculator2<string>.AreEqual("a", "a");
            if (equal)
            {
                Console.WriteLine("Equal!");
            }
            else
            {
                Console.WriteLine("Not Equal!");
            }

            Console.ReadLine();

        }
    }

    class Calculator
    {
        //public static bool AreEqual(int value1, int value2)
        //{
        //    return value1 == value2;
        //}
        //public static bool AreEqual(object value1, object value2)
        //{
        //    return value1 == value2;
        //}
        // to solve problem we use generics
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    class Calculator2<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
