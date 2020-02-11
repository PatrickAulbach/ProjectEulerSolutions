using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution012Tests
    {
        private readonly EulerProblem012 eulerProblem012;

        public Solution012Tests()
        {
            this.eulerProblem012 = new EulerProblem012();
        }

        [Fact]
        public void ComputeTriangleNumber_1()
        {
            var triangleNumber = eulerProblem012.ComputeTriangleNumber(1);
            Assert.Equal(1, triangleNumber);

        }

        [Fact]
        public void ComputeTriangleNumber_7()
        {
            var triangleNumber = eulerProblem012.ComputeTriangleNumber(7);
            Assert.Equal(28, triangleNumber);

        }

        [Fact]
        public void CountDivisorsFor_3()
        {
            var numDivisors = eulerProblem012.CountDivisors(3);
            Assert.Equal(2, numDivisors);

        }

        [Fact]
        public void CountDivisorsFor_6()
        {
            var numDivisors = eulerProblem012.CountDivisors(6);
            Assert.Equal(4, numDivisors);

        }

        [Fact]
        public void CountDivisorsFor_28()
        {
            var numDivisors = eulerProblem012.CountDivisors(28);
            Assert.Equal(6, numDivisors);

        }



        [Fact]
        public void FindTriangleWithDivisorNum_5()
        {
            var triangleNumber = eulerProblem012.CheckTriangleNumber(5);
            Assert.Equal(28, triangleNumber);

        }

        [Fact]
        public void FindTriangleWithDivisorNum_500()
        {
            var triangleNumber = eulerProblem012.CheckTriangleNumber(500);
            Assert.Equal(76576500, triangleNumber);

        }
    }
}
