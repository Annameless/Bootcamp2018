using System.IO;

namespace ClassesAndObjects
{
    public interface IGradeTracker
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter textWriter);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
    }
}