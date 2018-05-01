using System;

namespace TheArrayType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1 = { 1, 4, 9, 16 };
            var x2 = x1;

            Console.WriteLine("ReferenceEquals(x1, x2)" + ReferenceEquals(x1, x2));
            x1[0] = -3;
            Console.WriteLine("\nSo if I change the x1 element - x2 will get it too");
            Console.WriteLine("x2[0] == -3 " + (x2[0] == -3));
            x1[0] = 1;


            Console.WriteLine("\n== is the same as ReferenceEquals for arrays");
            int[] x3 = { 1, 4, 9, 16 };
            Console.WriteLine(string.Format("x1 == x2 is {0}", x1 == x2));
            Console.WriteLine(string.Format("x1 == x3 is {0}", x1 == x3));


            Console.WriteLine("\nIt's fine to store derived instances in the array, in example - anything can be stored in array");
            object[] objArray =
            {
                "Hello World",
                4,
                new Exception("Error message here")
            };

            foreach (var obj in objArray)
                Console.WriteLine(obj);


            Console.WriteLine("\n'String' is derived from 'object', but 'string[]' is derived from 'Array', so is the 'object[]'. 'Array' is derived from 'object'");
            var objArr = new object[3];
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("\nArray covariance: any direved array can be implicitly cast to base array");
            object[] objArr2 = daysOfWeek;
            foreach (var obj in objArr2)
                Console.WriteLine(obj);

            Console.WriteLine("\nCopy arrays");
            int[] squares = { 1, 4, 9, 16 };

            int[] copy = new int[7];
            squares.CopyTo(copy, 2);

            PrintArray(copy);
            Console.WriteLine("ReferenceEquals(squares, copy): " + ReferenceEquals(squares, copy));

            Console.WriteLine("\nReverse arrays");

            Array.Reverse(daysOfWeek);
            PrintArray(daysOfWeek);

            Console.WriteLine("\nSort arrays (default for string is alphabetical ordering)");
            Array.Sort(daysOfWeek);
            PrintArray(daysOfWeek);

            Console.WriteLine("\nSort arrays using custom comparers");
            Array.Sort(daysOfWeek, StringLengthComparer.Instance);
            PrintArray(daysOfWeek);

            Console.WriteLine("\nFind elements: indexOf");
            int indexOfTues = Array.IndexOf(daysOfWeek, "Tuesday");
            Console.WriteLine(indexOfTues);

            Console.WriteLine("\nFind elements: findIndex/findLastIndex");
            int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            Console.WriteLine(indexOfW);
            Console.WriteLine(daysOfWeek[indexOfW]);

            Console.WriteLine("\nFind elements: find all by predicate match");
            var sixLetters = Array.FindAll(daysOfWeek, x => x.Length == 6);
            PrintArray(sixLetters);

            Console.WriteLine("\nPerform binary search on arrays - one of the fastest way to search an element in huge arrays. " +
                              "Especially effective if arrayis sorted before search, Binary search can take IComparer to know how to compare elements");
            Array.Sort(daysOfWeek);
            var indexOfSun = Array.BinarySearch(daysOfWeek, "Sunday");
            Console.WriteLine("Index is " + indexOfSun);
        }

        static void PrintArray(int[] array){
            foreach(var value in array)
                Console.WriteLine(value);
        }

        static void PrintArray(string[] array)
        {
            foreach (var value in array)
                Console.WriteLine(value);
        }
    }
}
