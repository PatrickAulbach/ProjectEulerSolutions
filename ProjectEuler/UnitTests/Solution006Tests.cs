using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution006Tests
    {
        private readonly EulerProblem006 eulerProblem006;

        public Solution006Tests()
        {
            this.eulerProblem006 = new EulerProblem006(0);
        }

        [Fact]
        public void CheckSumOfSquaresFor_0()
        {
            eulerProblem006.NaturalNumber = 0;
            long sumOfSquares = eulerProblem006.ComputeSumOfSquares();
            Assert.Equal(0, sumOfSquares);
        }

        [Fact]
        public void CheckSumOfSquaresFor_1()
        {
            eulerProblem006.NaturalNumber = 1;
            long sumOfSquares = eulerProblem006.ComputeSumOfSquares();
            Assert.Equal(1, sumOfSquares);
        }

        [Fact]
        public void CheckSumOfSquaresFor_5()
        {
            eulerProblem006.NaturalNumber = 5;
            long sumOfSquares = eulerProblem006.ComputeSumOfSquares();
            Assert.Equal(55, sumOfSquares);
        }

        [Fact]
        public void CheckSumOfSquaresFor_10()
        {
            eulerProblem006.NaturalNumber = 10;
            long sumOfSquares = eulerProblem006.ComputeSumOfSquares();
            Assert.Equal(385, sumOfSquares);
        }

        [Fact]
        public void CheckSquaresOfSumsFor_0()
        {
            eulerProblem006.NaturalNumber = 0;
            long sumOfSquares = eulerProblem006.ComputeSquareOfSum();
            Assert.Equal(0, sumOfSquares);
        }

        [Fact]
        public void CheckSquaresOfSumsFor_1()
        {
            eulerProblem006.NaturalNumber = 1;
            long sumOfSquares = eulerProblem006.ComputeSquareOfSum();
            Assert.Equal(1, sumOfSquares);
        }

        [Fact]
        public void CheckSquaresOfSumsFor_5()
        {
            eulerProblem006.NaturalNumber = 5;
            long sumOfSquares = eulerProblem006.ComputeSquareOfSum();
            Assert.Equal(225, sumOfSquares);
        }

        [Fact]
        public void CheckSquaresOfSumsFor_10()
        {
            eulerProblem006.NaturalNumber = 10;
            long sumOfSquares = eulerProblem006.ComputeSquareOfSum();
            Assert.Equal(3025, sumOfSquares);
        }

        [Fact]
        public void SumSquareDifferenceFor_10()
        {
            eulerProblem006.NaturalNumber = 10;
            long sumOfSquares = eulerProblem006.SumSquareDifference();
            Assert.Equal(2640, sumOfSquares);
        }

        [Fact]
        public void SumSquareDifferenceFor_100()
        {
            eulerProblem006.NaturalNumber = 100;
            long sumOfSquares = eulerProblem006.SumSquareDifference();
            Assert.Equal(25164150, sumOfSquares);
        }
    }
}
