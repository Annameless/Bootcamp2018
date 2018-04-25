using System;
using System.Collections.Generic;

namespace ClassesAndObjects
{
    public class GradeBook
    {
        private List<float> grades;
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value)){
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
        }

        public event NameChangedDelegate NameChanged;

        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        public void AddGrade(float grade){
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics(){
            float sum = 0f;
            var lowest = grades.Count > 0? grades[0] : 0f;
            var highest = grades.Count > 0 ? grades[0] : 0f;
            foreach(var grade in grades){
                sum += grade;

                lowest = Math.Min(lowest, grade);
                highest = Math.Max(highest, grade);
            }
            var avg = sum > 0 ? sum / grades.Count : 0;
            return new GradeStatistics(avg, highest, lowest);
        }
    }
}
