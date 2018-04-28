using System;

namespace ComparisonsInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reference type comparison: string");
            var apple = "apple";
            var pear = "pear";

            DisplayOrder(apple, pear);
            DisplayOrder(pear, apple);
            DisplayOrder(apple, apple);

            Console.WriteLine("\nPrimitive value type comparison: int");
            DisplayOrder(3, 5);
            DisplayOrder(5, 3);
            DisplayOrder(4, 4);

            Console.WriteLine("\nCustom value type comparison: struct");
            var cl200 = new CalorieCount(200);
            var cl300 = new CalorieCount(300);

            DisplayOrder(cl200, cl300);
            DisplayOrder(cl300, cl300);
            DisplayOrder(cl300, cl200);

            if(cl200 < cl300)
                Console.WriteLine("{0} < {1}", cl200, cl300);
        }

        public static void DisplayOrder<T>(T x, T y) where T : IComparable<T>{
            var result = x.CompareTo(y);
            if (result == 0)
                Console.WriteLine("{0} = {1}", x, y);
            else if (result > 0)
                Console.WriteLine("{0} > {1}", x, y);
            else
                Console.WriteLine("{0} < {1}", x, y);
        }
    }
}
