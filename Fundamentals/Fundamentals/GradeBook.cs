using System;
using System.Collections.Generic;
using System.IO;

namespace Fundamentals
{
    public class GradeBook : GradeTracker
    {
        protected List<float> _grades;

        public GradeBook()
        {
            _grades = new List<float>();
            _name = string.Empty;
        }

        public override void AddGrade(float grade){
            _grades.Add(grade);
        }

        public override void WriteGrades(TextWriter textWriter){
            for (int i = 0; i < _grades.Count; i++)
            {
                textWriter.WriteLine(_grades[i]);
            }
        }

        public override GradeStatistics ComputeStatistics(){
            float sum = 0f;
            var lowest = _grades.Count > 0? _grades[0] : 0f;
            var highest = _grades.Count > 0 ? _grades[0] : 0f;
            foreach(var grade in _grades){
                sum += grade;

                lowest = Math.Min(lowest, grade);
                highest = Math.Max(highest, grade);
            }
            var avg = sum > 0 ? sum / _grades.Count : 0;
            return new GradeStatistics(avg, highest, lowest);
        }
    }
}
