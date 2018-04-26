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



        public string LetterGrade
        {
            get
            {
                string result = "F";
                if (Average >= 90)
                    result = "A";
                else if (Average >= 80)
                    result = "B";
                else if (Average >= 70)
                    result = "C";
                return result;
            }
        }

        public string Description{
            get{
                switch(LetterGrade){
                    case "A":
                        return "excelent";
                    case "B":
                        return "average";
                    case "C":
                        return "below average";
                    default:
                        return "Failing";
                }
            }
        }

        public float Average { get => average; set => average = value; }
        public float Highest { get => highest; set => highest = value; }
        public float Lowest { get => lowest; set => lowest = value; }
    }
}
