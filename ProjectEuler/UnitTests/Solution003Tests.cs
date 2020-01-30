using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution003Tests
    {
        private readonly EulerProblem003 eulerProblem003;

        public Solution003Tests()
        {
            this.eulerProblem003 = new EulerProblem003();
        }

        [Fact]
        public void CheckIf_13_isPrime()
        {
            var isPrime = eulerProblem003.IsPrime(13);
            Assert.True(isPrime);
        }

        [Fact]
        public void CheckIf_166_isPrime()
        {
            var isPrime = eulerProblem003.IsPrime(166);
            Assert.False(isPrime);
        }

        [Fact]
        public void CheckIf_673_isPrime()
        {
            var isPrime = eulerProblem003.IsPrime(673);
            Assert.True(isPrime);
        }

        [Fact]
        public void CheckIf_997_isPrime()
        {
            var isPrime = eulerProblem003.IsPrime(997);
            Assert.True(isPrime);
        }

        [Fact]
        public void CheckPrimeFactorFor_13195()
        {
            var primeFactor = eulerProblem003.Solution(13195);
            Assert.Equal(29, primeFactor);
        }

        [Fact]
        public void CheckPrimeFactorFor_600851475143()
        {
            var primeFactor = eulerProblem003.Solution(600851475143);
            Assert.Equal(6857, primeFactor);
        }

    }
}
