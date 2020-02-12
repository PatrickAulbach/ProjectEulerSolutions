using Xunit;
using ProjectEuler.ProjectEulerSolutions;

namespace ProjectEuler.UnitTests
{
    public class Solution015Tests
    {
        private readonly EulerProblem015 eulerProblem015;

        public Solution015Tests()
        {
            this.eulerProblem015 = new EulerProblem015();
        }

        [Fact]
        public void ComputeBinomialCoefficient_2()
        {
            var binomialCoefficient = eulerProblem015.BinomialCoefficient(2, 2);
            Assert.Equal(6, binomialCoefficient);

        }

        [Fact]
        public void ComputeBinomialCoefficient_20()
        {
            var binomialCoefficient = eulerProblem015.BinomialCoefficient(20, 20);
            Assert.Equal(137846528820, binomialCoefficient);

        }
    }
}
