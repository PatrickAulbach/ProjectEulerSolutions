using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution007Tests
    {
        private readonly EulerProblem007 eulerProblem007;

        public Solution007Tests()
        {
            this.eulerProblem007 = new EulerProblem007();
        }
        [Fact]
        public void CheckPrimePosition_3()
        {
            long prime = eulerProblem007.CountPrimeNumbers(3);
            Assert.Equal(5, prime);
        }

        [Fact]
        public void CheckPrimePosition_6()
        {
            long prime = eulerProblem007.CountPrimeNumbers(6);
            Assert.Equal(13, prime);
        }

        [Fact]
        public void CheckPrimePosition_10001()
        {
            long prime = eulerProblem007.CountPrimeNumbers(10001);
            Assert.Equal(104743, prime);
        }
    }
}
