using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution010Tests
    {
        private readonly EulerProblem010 eulerProblem010;

        public Solution010Tests()
        {
            this.eulerProblem010 = new EulerProblem010();
        }

        [Fact]
        public void FindSumOfPrimesBelow_10()
        {
            var sumOfPrimes = eulerProblem010.SumOfPrimes(10);
            Assert.Equal(17, sumOfPrimes);
           
        }

        [Fact]
        public void FindSumOfPrimesBelow_2000000()
        {
            var sumOfPrimes = eulerProblem010.SumOfPrimes(2000000);
            Assert.Equal(142913828922, sumOfPrimes);

        }
    }
}
