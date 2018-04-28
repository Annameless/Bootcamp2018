using System;

namespace CustomEqualityImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value type equality implemtation");
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


            Console.WriteLine("\nReference type equality implemtation");
            var apple = new FoodItem("apple", FoodGroup.Fruit);
            var stewedAppple = new CookedFoodItem("stewed", "apple", FoodGroup.Fruit);
            var stewedAppple2 = new CookedFoodItem("stewed", "apple", FoodGroup.Fruit);
            var bakedApple = new CookedFoodItem("baked", "apple", FoodGroup.Fruit);
            var apple2 = new FoodItem("apple", FoodGroup.Fruit);

            DisplayWhetherEqual(apple, stewedAppple);
            DisplayWhetherEqual(stewedAppple, bakedApple);
            DisplayWhetherEqual(stewedAppple, stewedAppple2);
            DisplayWhetherEqual(apple, apple2);
            DisplayWhetherEqual(apple, apple);
        }

        public static void DisplayWhetherEqual(FoodItem i1, FoodItem i2){
            if (i1 == i2)
                Console.WriteLine(string.Format("{0,12} == {1}", i1, i2));
            else
                Console.WriteLine(string.Format("{0,12} != {1}", i1, i2));
        }
    }
}
