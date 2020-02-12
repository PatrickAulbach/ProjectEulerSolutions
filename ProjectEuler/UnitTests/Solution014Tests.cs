using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ProjectEuler.ProjectEulerSolutions;

namespace ProjectEuler.UnitTests
{
    public class Solution014Tests
    {
        private readonly EulerProblem014 eulerProblem014;

        public Solution014Tests()
        {
            this.eulerProblem014 = new EulerProblem014();
        }

        [Fact]
        public void ComputeLongestCollatzSequence()
        {
            var  longestCollatzSequence = eulerProblem014.ComputeLongestCollatzSequenz();
            Assert.Equal(837799, longestCollatzSequence);

        }
    }
}
