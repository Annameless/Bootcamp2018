using System;
using Xunit;

namespace ClassesAndObjects.UnitTests.Types
{
    public class TypesTests
    {
        [Fact]
        public void ValueTypesPassByValue()
        {
            int x1 = 10;
            Increment(x1);

            Assert.Equal(10, x1);
        }

        private void Increment(int number){
            number++;
        }

        [Fact]
        public void ReferenceTypesPassByValue()
        {
            var g1 = new GradeBook();
            var g2 = g1;

            GiveBookName(g2);

            Assert.Equal("A GradeBook", g1.Name);
        }

        private void GiveBookName(GradeBook book){
            book.Name = "A GradeBook";
        }

        [Fact]
        public void IfVariableHoldsReference(){
            var g1 = new GradeBook();
            var g2 = g1;

            g1.Name = "Kate's grade book";

            Assert.Equal(g1.Name, g2.Name);
        }

        [Fact]
        public void IfVariableHoldsValue()
        {
            int x1 = 10;
            var x2 = x1;

            x1 = 4;

            Assert.NotEqual(x1, x2);
        }


        [Fact]
        public void StringComparison(){
            var s1 = "Harry";
            var s2 = "harry";

            Assert.True(string.Equals(s1, s2, System.StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void AddDaysToDateTime(){
            var date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);
            Assert.Equal(2, date.Day);
        }

        [Fact]
        public void UppercasesString(){
            var s = "Nanny";
            s = s.ToUpper();
            Assert.Equal("NANNY", s);
        }

        [Fact]
        public void UsingArrays(){
            float[] grades = new float[3];

            AddGrades(grades);

            Assert.Equal(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }
    }
}
