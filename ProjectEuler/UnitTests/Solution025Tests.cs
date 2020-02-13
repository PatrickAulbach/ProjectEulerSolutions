using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution025Tests
    {
        private readonly EulerProblem025 eulerProblem025;

        public Solution025Tests()
        {
            this.eulerProblem025 = new EulerProblem025();
        }

        [Fact]
        public void Compute15PowerOf_2()
        {
            var digit = eulerProblem025.ComputeFibonacci();
            Assert.Equal(4782, digit);

        }
    }
}
