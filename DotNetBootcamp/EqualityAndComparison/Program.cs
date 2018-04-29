using System;
using System.Collections.Generic;
using CustomEqualityImplementation;

namespace EqualityAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new[]{ 
                new FoodItem("orange", FoodGroup.Fruit),
                new FoodItem("banana", FoodGroup.Fruit),
                new FoodItem("pear", FoodGroup.Fruit),
                new FoodItem("apple", FoodGroup.Fruit)
            };

            Console.WriteLine("\n:IComparer");
            Array.Sort(list, new FoodItemNameComparer_IComparer());

            foreach(var item in list)
                Console.WriteLine(item);


            Console.WriteLine("\n:Comparer");
            Array.Sort(list, new FoodItemNameComparer_Comparer());

            foreach (var item in list)
                Console.WriteLine(item);


            Console.WriteLine("\n:Comparer Singleton");
            SortAndShow(list);


            Console.WriteLine("\nList of FoodItems and inherited from FoodItem CookedFoodItems");
            var list1 = new[]{
                new FoodItem("pear", FoodGroup.Fruit),
                new FoodItem("apple", FoodGroup.Fruit),
                new CookedFoodItem("baked", "apple", FoodGroup.Fruit)
            };
            SortAndShow(list1);

            var list2 = new[]{
                new CookedFoodItem("baked", "apple", FoodGroup.Fruit),
                new FoodItem("pear", FoodGroup.Fruit),
                new FoodItem("apple", FoodGroup.Fruit)
            };
            Console.WriteLine();
            SortAndShow(list2);

            Console.WriteLine("\nCollections leverage Equality Comparers");
            var foodStructs = new HashSet<FoodStruct>(FoodStructEqualityComparer.Instance){
                new FoodStruct("pineapple", FoodGroup.Fruit),
                new FoodStruct("apple", FoodGroup.Fruit),
                new FoodStruct("pear", FoodGroup.Fruit),
                new FoodStruct("Apple", FoodGroup.Fruit)
            };

            foreach (var item in foodStructs)
                Console.WriteLine(item);

            Console.WriteLine("\nCollections leverage Equality Comparers: Default EqualityComparer");
            var foodStructs1 = new HashSet<FoodStruct>(EqualityComparer<FoodStruct>.Default){
                new FoodStruct("pineapple", FoodGroup.Fruit),
                new FoodStruct("apple", FoodGroup.Fruit),
                new FoodStruct("pear", FoodGroup.Fruit),
                new FoodStruct("Apple", FoodGroup.Fruit)
            };

            foreach (var item in foodStructs1)
                Console.WriteLine(item);

            Console.WriteLine("\nString Comparer");
            var names = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase){
                "apple",
                "pear",
                "pineapple",
                "Apple"
            };

            foreach (var item in names)
                Console.WriteLine(item);
        }

        static void SortAndShow(FoodItem[] list)
        {
            Array.Sort(list, FoodItemNameComparer_ComparerSingleton.Instance);

            foreach (var item in list)
                Console.WriteLine(item);
        }    
    }
}
