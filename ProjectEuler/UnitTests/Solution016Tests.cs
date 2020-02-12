using Xunit;
using ProjectEuler.ProjectEulerSolutions;

namespace ProjectEuler.UnitTests
{
    public class Solution016Tests
    {
        private readonly EulerProblem016 eulerProblem016;

        public Solution016Tests()
        {
            this.eulerProblem016 = new EulerProblem016();
        }

        [Fact]
        public void Compute15PowerOf_2()
        {
            var digit = eulerProblem016.PowerDigitSum(2, 15);
            Assert.Equal(26, digit);

        }

        [Fact]
        public void Compute1000PowerOf_2()
        {
            var digit = eulerProblem016.PowerDigitSum(2, 1000);
            Assert.Equal(1366, digit);

        }
    }
}
