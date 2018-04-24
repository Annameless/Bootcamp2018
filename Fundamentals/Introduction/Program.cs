using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please...");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            var hours = FigureOutLevelOfSleepiness();

            if (hours >= 8)
                Console.WriteLine("You are well rested");
            else
                Console.WriteLine("You need some sleep");
        }

        private static decimal FigureOutLevelOfSleepiness(){
            Console.WriteLine("How many hours of sleep did you get last night...");
            decimal hours;
            var isSuccess = decimal.TryParse(Console.ReadLine(), out hours);
            if(!isSuccess) {
                Console.WriteLine("Please enter a number");
                return FigureOutLevelOfSleepiness();
            }
            return hours;
        }
    }
}
