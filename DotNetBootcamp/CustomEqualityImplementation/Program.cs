using System;

namespace CustomEqualityImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var banana = new FoodItem("banana", FoodGroup.Fruit);
            var banana2 = new FoodItem("banana", FoodGroup.Fruit);
            var chocolate = new FoodItem("chocolate", FoodGroup.Sweets);

            Console.WriteLine("banana == banana2? " + (banana == banana2));
            Console.WriteLine("banana2 == chocolate? " + (banana2 == chocolate));
            Console.WriteLine("chocolate == banana? " + (chocolate == banana));

            Console.WriteLine("banana != banana2? " + (banana != banana2));
            Console.WriteLine("banana2 != chocolate? " + (banana2 != chocolate));
            Console.WriteLine("chocolate != banana? " + (chocolate != banana));

            Console.WriteLine("banana.Equals(banana2)? " + (banana.Equals(banana2)));
            Console.WriteLine("banana2.Equals(chocolate)? " + (banana2.Equals(chocolate)));
            Console.WriteLine("chocolate.Equals(banana)? " + (chocolate.Equals(banana)));
        }
    }
}
