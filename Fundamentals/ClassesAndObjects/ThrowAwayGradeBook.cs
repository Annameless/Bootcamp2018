using System;
namespace ClassesAndObjects
{
    public class ThrowAwayGradeBook : GradeBook
    {

        public override GradeStatistics ComputeStatistics()
        {
            var lowest = float.MaxValue;
            foreach (var grade in _grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            _grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
