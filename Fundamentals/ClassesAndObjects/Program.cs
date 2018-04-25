using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(81.5f);
            book.AddGrade(57f);

            var stats = book.ComputeStatistics();
            Console.WriteLine("Average: {0}, Highest: {1}, Lowest: {2}", stats.Average, stats.Highest, stats.Lowest);
        }
    }
}
