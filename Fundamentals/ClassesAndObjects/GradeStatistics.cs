using System;
namespace ClassesAndObjects
{
    public class GradeStatistics
    {
        private float average;
        private float highest;
        private float lowest;

        public GradeStatistics(float a, float h, float l)
        {
            Average = a;
            Highest = h;
            lowest = l;
        }

        public float Average { get => average; set => average = value; }
        public float Highest { get => highest; set => highest = value; }
        public float Lowest { get => lowest; set => lowest = value; }
    }
}
