using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.NameChanged += new NameChangedDelegate(OnNameChanged2);

            book.Name = "Mille's Grade book";
            book.AddGrade(91);
            book.AddGrade(81.5f);
            book.AddGrade(75f);

            book.Name = "Kate's Grade book";

            book.Name = "Dan's Grade book";

            var stats = book.ComputeStatistics();
            WriteResult("Average", stats.Average);
            WriteResult("Highest", stats.Highest);
            WriteResult("Lowest", stats.Lowest);
            Console.WriteLine("Average: {0}, Highest: {1}, Lowest: {2}", stats.Average, stats.Highest, stats.Lowest);
        }

        static void WriteResult(string desc, float result){
            Console.WriteLine($"{desc}: {result:F2}");
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args){
            Console.WriteLine($"Book name is changed from {args.ExistingName} to {args.NewName}");
        }

        static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***");
        }
    }
}
