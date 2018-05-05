using System;
using System.Collections.Generic;

namespace Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Will enumerate elements of the array");
            string[] daysOfWeek = {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Friday",
                                      "Saturday",
                                      "Sunday"
                                  };
            DisplayItems(daysOfWeek);

            Console.WriteLine("\nWill enumerate the characters in the string");
            DisplayItems("Hello, World!");

            Console.WriteLine("\nImplementing own enumerator");
            var alldays = new AllDaysOfWeek();
            foreach(var d in alldays){
                Console.WriteLine(d);
            }
        }

        static void DisplayItems<T>(IEnumerable<T> collection){
            using(var enumerator = collection.GetEnumerator()){
                var hasNext = enumerator.MoveNext();
                while(hasNext){
                    Console.WriteLine(enumerator.Current);
                    hasNext = enumerator.MoveNext();
                }
            }
        }
    }
}
