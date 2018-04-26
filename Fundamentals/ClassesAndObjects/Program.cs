using System;
using System.IO;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            SubscribeToEvent(book);

            SetBookName(book);
            AddGrades(book);
            WriteGrades(book);
            PrintGrades(book);
        }

        private static void SubscribeToEvent(GradeBook book)
        {
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.NameChanged += new NameChangedDelegate(OnNameChanged2);
        }

        private static void PrintGrades(GradeBook book)
        {
            var stats = book.ComputeStatistics();
            WriteResult("Average", stats.Average);
            WriteResult("Highest", stats.Highest);
            WriteResult("Lowest", stats.Lowest);
            WriteResult("Grade", stats.LetterGrade);
            WriteResult("Description", stats.Description);
        }

        private static void WriteGrades(GradeBook book)
        {
            using (var output = File.CreateText("grades.txt"))
            {
                book.WriteGrades(output);
                output.Close();
                File.Delete("grades.txt");
            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(81.5f);
            book.AddGrade(75f);
        }

        private static void SetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter the book name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                book.Name = "Mille's Grade book";
            }
        }

        static void WriteResult(string desc, float result){
            Console.WriteLine($"{desc}: {result:F2}");
        }

        static void WriteResult(string desc, string result)
        {
            Console.WriteLine($"{desc}: {result}");
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args){
            Console.WriteLine($"Book name is changed from '{args.ExistingName}' to '{args.NewName}'");
        }

        static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***");
        }
    }
}
