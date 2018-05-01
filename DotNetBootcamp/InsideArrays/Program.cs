using System;

namespace InsideArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOfWeek = new[]{
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            var tuesday = daysOfWeek[1];
            Console.WriteLine(tuesday);

            Console.WriteLine("\nType in index of day to look up (0 - 6)>:");
            int dayIdx;
            var isInt = int.TryParse(Console.ReadLine(), out dayIdx);
            if(!isInt)
                Console.WriteLine("Enter integer would be lovely, but then next time you run the program");
            else{
                if(dayIdx > 6)
                    Console.WriteLine("Not valid index, from 0 to 6");
                else
                    Console.WriteLine(daysOfWeek[dayIdx]);
            }

            Console.WriteLine("\nIterate through the array: foreach");
            PrintArray(daysOfWeek);


            Console.WriteLine("\nIterate through the array: for loop");
            for (var i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }

            Console.WriteLine("\nReplace element by the item index");
            daysOfWeek[5] = "PartyDay";
            PrintArray(daysOfWeek);

            Console.WriteLine("\n'For' loop give access to the element itself rather than to a copy of it like in 'foreach' loop. " +
                              "So that array's element can be only replaced within for loop, foreach loop can't");
            MakeDaysPlural(daysOfWeek);
            PrintArray(daysOfWeek);

            Console.WriteLine("\nForeach loop can't replace the elements, but it can modify values of elements");
            var people = new []
            {
                new Person {Name="Bill", Age=7},
                new Person {Name="Ben", Age=8}
            };

            foreach (var person in people)
                person.Age = 20;

            foreach (var person in people)
                Console.WriteLine(person);
        }


        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (var i = 0; i < daysOfWeek.Length; i++)
            {
                daysOfWeek[i] = daysOfWeek[i] + "s";
            }
        }

        static void PrintArray(string[] array){
            foreach(var element in array)
                Console.WriteLine(element);
        }
    }
}
