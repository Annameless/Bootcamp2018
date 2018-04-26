using System;
using System.IO;

namespace ClassesAndObjects
{
    public abstract class GradeTracker: Object, IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter textWriter);

        protected string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (_name != value && NameChanged != null)
                {
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
    }
}
