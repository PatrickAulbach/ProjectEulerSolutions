using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution011Tests
    {
        private readonly EulerProblem011 eulerProblem011;

        public Solution011Tests()
        {
            this.eulerProblem011 = new EulerProblem011();
        }

        [Fact]
        public void FindMaxProductOfAdjacentNumbers_4()
        {
            var largestProduct = eulerProblem011.FindLargestProduct();     
            Assert.Equal(70600674, largestProduct);

        }
    }
}
