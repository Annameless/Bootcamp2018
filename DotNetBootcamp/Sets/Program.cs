using System;
using System.Collections.Generic;
using System.Linq;
using Dictionaries;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashset is the same as list but by default provided uniqueness of the elements inside");
            var bigCities = new HashSet<string>
            { 
                "New York", 
                "Manchester", 
                "Sheffield", 
                "Paris" 
            };
            bool addedSheffield = bigCities.Add("Sheffield");
            bool addedBeijing = bigCities.Add("Beijing");
            Console.WriteLine("Added Sheffield? " + addedSheffield);
            Console.WriteLine("Added Beijing? " + addedBeijing);
            Console.WriteLine();

            PrintHashSet(bigCities);

            Console.WriteLine("\n IEqualityComparer default and custom can be used with HashSet");
            var bigCities2 = new HashSet<string>(new UncasedStringEqualityComparer()) { "New York", "Manchester", "Sheffield", "Paris" };
            bigCities2.Add("SHEFFIELD");
            bigCities2.Add("BEIJING");

            PrintHashSet(bigCities2);

            var bigCities3 = new HashSet<string>{ "New York", "Manchester", "Sheffield", "Paris" };
            string[] citiesInUk = { "Sheffield", "Ripon", "Truro", "Manchester" };

            Console.WriteLine("\nExceptWith - find values that are in ONLY THE FIRSTS collection");
            bigCities3.ExceptWith(citiesInUk);
            PrintHashSet(bigCities3);

            Console.WriteLine("\nSymmetricExceptWith - find values that are in ONLY ONE collection");
            bigCities3.SymmetricExceptWith(citiesInUk);
            PrintHashSet(bigCities3);

            Console.WriteLine("\nUnionWith");
            bigCities3.UnionWith(citiesInUk);
            PrintHashSet(bigCities3);

            Console.WriteLine("\nIntersection - LINQ");
            var newCities = bigCities3.Intersect(citiesInUk);
            foreach (string city in newCities)
                Console.WriteLine(city);

            Console.WriteLine("\nIntersectWith - modifies ISet inline - changes the set itself - doesn't create a new set with result of intersection");
            bigCities3.IntersectWith(citiesInUk);
            PrintHashSet(bigCities3);

            Console.WriteLine("\nComparing Elements with SetEquals");
            bigCities = new HashSet<string>
            { "New York", "Manchester", "Sheffield", "Paris" };

            var citiesInUkHS = new HashSet<string>
            { "Sheffield", "Ripon", "Truro", "Manchester" };

            var bigCitiesArr = new string[]
            { "Paris", "Sheffield", "New York", "Manchester" };

            bool areEqual = bigCities.SetEquals(bigCitiesArr);
            Console.WriteLine("bigCities = bigCitiesArr? " + areEqual);

            bool areEqualUk = citiesInUkHS.SetEquals(bigCitiesArr);
            Console.WriteLine("citiesInUkHS = bigCitiesArr? " + areEqualUk);

            Console.WriteLine("\nComparisons ans Subsets");
            var ukCities = new HashSet<string>
            { "Sheffield", "Ripon", "Truro", "Manchester" };

            var bigUkCities = new HashSet<string>
            { "Sheffield", "Manchester" };

            var bigCitiesArrHS = new HashSet<string>
            { "New York", "Manchester", "Sheffield", "Paris" };

            //  bool ukIsSubset = ukCities.IsSubsetOf(bigCitiesArrHS);
            bool ukIsSubset = bigCitiesArrHS.IsSupersetOf(ukCities);
            Console.WriteLine("UK cities subset of big cities? " + ukIsSubset);

            // bool bigUkIsSubset = bigUkCities.IsSubsetOf(bigCitiesArrHS);
            bool bigUkIsSubset = bigCitiesArrHS.IsSupersetOf(bigUkCities);

            Console.WriteLine("Big UK cities subset of big cities? " + bigUkIsSubset);

            Console.WriteLine("\nSortedSet: default in alphabetical order, custom IComparer can be implemented");
            var bigCities4 = new SortedSet<string>(new UncasedStringComparer()) { "New York", "Manchester", "Sheffield", "Paris" };
            bigCities4.Add("SHEFFIELD");
            bigCities4.Add("BEIJING");

            PrintHashSet(bigCities4);
        }

        static void PrintHashSet(ISet<string> s){
            foreach (string item in s)
                Console.WriteLine(item);
        }
    }
}
