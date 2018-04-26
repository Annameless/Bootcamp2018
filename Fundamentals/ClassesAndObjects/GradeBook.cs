using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesAndObjects
{
    public class GradeBook
    {
        private List<float> _grades;
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if(_name != value){
                    NameChanged(this, new NameChangedEventArgs
                    {
                        ExistingName = _name,
                        NewName = value
                    });
                }

                _name = value;
            }
        }

        public event NameChangedDelegate NameChanged;

        public GradeBook()
        {
            _grades = new List<float>();
            _name = string.Empty;
        }

        public void AddGrade(float grade){
            _grades.Add(grade);
        }

        public void WriteGrades(TextWriter writer){
            for (int i = 0; i < _grades.Count; i++)
            {
                writer.WriteLine(_grades[i]);
            }
        }

        public GradeStatistics ComputeStatistics(){
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
