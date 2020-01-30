using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution002Tests
    {
        private readonly EulerProblem002 eulerProblem002;

        public Solution002Tests()
        {
            this.eulerProblem002 = new EulerProblem002();
        }

        [Fact]
        public void ComputeFibonacciFor_1()
        {
            var sum = eulerProblem002.Solution(1);
            Assert.Equal(1, sum);
        }

        [Fact]
        public void ComputeFibonacciFor_5()
        {
            var sum = eulerProblem002.Solution(5);
            Assert.Equal(5, sum);
        }

        [Fact]
        public void ComputeFibonacciFor_8()
        {
            var sum = eulerProblem002.Solution(8);
            Assert.Equal(21, sum);
        }

        [Fact]
        public void ComputeFibonacciFor_10()
        {
            var sum = eulerProblem002.Solution(10);
            Assert.Equal(55, sum);
        }

        [Fact]
        public void ComputeFibonacciFor_15()
        {
            var sum = eulerProblem002.Solution(15);
            Assert.Equal(610, sum);
        }

        [Fact]
        public void ComputeFibonacciFor_37()
        {
            var sum = eulerProblem002.Solution(37);
            Assert.Equal(24157817, sum);
        }
    }
}
