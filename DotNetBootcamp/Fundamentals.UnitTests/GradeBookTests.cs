using Xunit;

namespace Fundamentals.UnitTests
{
    public class GradeBookTests
    {
        [Fact]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            Assert.Equal(90, book.ComputeStatistics().Highest);
        }

        [Fact]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            Assert.Equal(10, book.ComputeStatistics().Lowest);
        }

        [Fact]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            Assert.Equal(85.1667f, book.ComputeStatistics().Average, 1);
        }
    }
}
