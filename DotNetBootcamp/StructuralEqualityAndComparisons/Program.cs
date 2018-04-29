using System;
using System.Collections;

namespace StructuralEqualityAndComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new[] { "apple", "orange", "pineapple" };
            var arr2 = new[] { "apple", "orange", "Pineapple" };

            Console.WriteLine("arr1 == arr2: " + (arr1 == arr2));
            Console.WriteLine("arr1.Equals(arr2): " + arr1.Equals(arr2));

            var arrayEq = (IStructuralEquatable)arr1;
            var structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine("arrayEq.Equals(arr2, StringComparer.Ordinal): " + structEqual);
            Console.WriteLine("IStructuralEquatable works with arrays and tuples only");

            var arr3 = new[] { "apple", "orange", "pineapple" };
            var arr4 = new[] { "apple", "pear", "pineapple" };

            var arrayCmp = (IStructuralComparable)arr3;
            var structCmp = arrayCmp.CompareTo(arr4, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine("\narrayCmp.CompareTo(arr4, StringComparer.OrdinalIgnoreCase): " + structCmp);
            Console.WriteLine("IStructuralComparable works with arrays and tuples");
        }
    }
}
