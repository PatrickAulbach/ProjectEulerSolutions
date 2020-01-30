using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution005Tests
    {
        private readonly EulerProblem005 eulerProblem005;

        public Solution005Tests()
        {
            this.eulerProblem005 = new EulerProblem005(10, 0);
        }

        [Fact]
        public void CheckForSmallestNumberForDivisor_10()
        {
            long smallestNumber = eulerProblem005.FindSmallestNumber();
            Assert.Equal(2520, smallestNumber);
        }

        [Fact]
        public void CheckForSmallestNumberForDivisor_20()
        {
            eulerProblem005.StartNumber = 2520;
            eulerProblem005.MaxDivisor = 20;
            long smallestNumber = eulerProblem005.FindSmallestNumber();
            Assert.Equal(232792560, smallestNumber);
        }
    }
}
