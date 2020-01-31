using ProjectEuler.ProjectEulerSolutions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution009Tests
    {
        private readonly EulerProblem009 eulerProblem009;

        public Solution009Tests()
        {
            this.eulerProblem009 = new EulerProblem009();
        }

        [Fact]
        public void FindPythagoreanTripletFor_12()
        {
            var triplet = eulerProblem009.FindPythagoreanTriplet(12);
            Assert.Equal(3, triplet.Item1);
            Assert.Equal(4, triplet.Item2);
            Assert.Equal(5, triplet.Item3);
        }

        [Fact]
        public void FindPythagoreanTripletFor_1000()
        {
            var triplet = eulerProblem009.FindPythagoreanTriplet(1000);
            Assert.Equal(200, triplet.Item1);
            Assert.Equal(375, triplet.Item2);
            Assert.Equal(425, triplet.Item3);
        }
    }
}
