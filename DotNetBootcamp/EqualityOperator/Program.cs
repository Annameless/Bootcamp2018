using System;

namespace EqualityOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primitive value types: int");
            Console.WriteLine("AreIntEqual_EqualityOperator(3, 3)? " + AreIntEqual_EqualityOperator(3, 3));
            Console.WriteLine("AreIntsEqual_ObjectEqualityMethod(3, 3)? " + AreIntsEqual_ObjectEqualityMethod(3, 3));

            Console.WriteLine("\nReference types: Button");
            var button = new Button("Press");
            var button2 = new Button("Press");
            Console.WriteLine("AreButtonsEqual_EqualityOperator(button, button2)? " + AreButtonsEqual_EqualityOperator(button, button2));
            Console.WriteLine("AreButtonsEqual_ObjectEqualityMethod(button, button2)? " + AreButtonsEqual_ObjectEqualityMethod(button, button2));

            Console.WriteLine("\nReference types: String");
            var str = "String";
            var str2 = string.Copy(str);
            Console.WriteLine("ReferenceEquals(str, str2)? " + ReferenceEquals(str, str2));
            Console.WriteLine("AreStringEqual_EqualityOperator(str, str2)? " + AreStringEqual_EqualityOperator(str, str2));
            Console.WriteLine("AreStringEqual_ObjectEqualityMethod(str, str2)? " + AreStringEqual_ObjectEqualityMethod(str, str2));

            Console.WriteLine("\nReference types: Tuple");
            var t1 = Tuple.Create(1, 3);
            var t2 = Tuple.Create(1, 3);
            Console.WriteLine("ReferenceEquals(t1, t2)? " + ReferenceEquals(t1, t2));
            Console.WriteLine("AreTuplesEqual_EqualityOperator(t1, t2)? " + AreTuplesEqual_EqualityOperator(t1, t2));
            Console.WriteLine("AreTuplesEqual_ObjectEqualityMethod(t1, t2)? " + AreTuplesEqual_ObjectEqualityMethod(t1, t2));

            Console.WriteLine("\n== with generics doesn't work, object.Equals does");
            DisplayWhetherArgsAreEqual_EqualityOperator(str, str2);
            DisplayWhetherArgsAreEqual_ObjectEqualityMethod(str, str2);
        }

        public static bool AreIntEqual_EqualityOperator(int x, int y){
            return x == y;
        }

        public static bool AreIntsEqual_ObjectEqualityMethod(int x, int y){
            return x.Equals(y);
        }

        public static bool AreButtonsEqual_EqualityOperator(Button x, Button y)
        {
            return x == y;
        }

        public static bool AreButtonsEqual_ObjectEqualityMethod(Button x, Button y)
        {
            return x.Equals(y);
        }

        public static bool AreStringEqual_EqualityOperator(string x, string y)
        {
            return x == y;
        }

        public static bool AreStringEqual_ObjectEqualityMethod(string x, string y)
        {
            return x.Equals(y);
        }

        public static bool AreTuplesEqual_EqualityOperator(Tuple<int, int> x, Tuple<int, int> y)
        {
            return x == y;
        }

        public static bool AreTuplesEqual_ObjectEqualityMethod(Tuple<int, int> x, Tuple<int, int> y)
        {
            return x.Equals(y);
        }

        public static void DisplayWhetherArgsAreEqual_EqualityOperator<T>(T x, T y) where T: class{
            Console.WriteLine("DisplayWhetherArgsAreEqual_EqualityOperator<T>(string 'A' == string 'A')? " + (x == y));
        }

        public static void DisplayWhetherArgsAreEqual_ObjectEqualityMethod<T>(T x, T y) where T : class
        {
            Console.WriteLine("DisplayWhetherArgsAreEqual_ObjectEqualityMethod<T>(object.Equals(string 'A', string 'A'))? " + Equals(x, y));
        }
    }
}
