using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution001Tests
    {
        private readonly EulerProblem001 eulerProblem001;

        public Solution001Tests()
        {
            this.eulerProblem001 = new EulerProblem001();
        }

        [Fact]
        public void FindMultiplesBelow_16()
        {
            var sum = eulerProblem001.Solution(16);
            Assert.Equal(60, sum);
        }

        [Fact]
        public void FindMultiplesBelow_13()
        {
            var sum = eulerProblem001.Solution(13);
            Assert.Equal(45, sum);
        }

        [Fact]
        public void FindMultiplesBelow_10()
        {
            var sum = eulerProblem001.Solution(10);
            Assert.Equal(23, sum);
        }

        [Fact]
        public void FindMultiplesBelow_5()
        {
            var sum = eulerProblem001.Solution(5);
            Assert.Equal(3, sum);
        }

        [Fact]
        public void FindMultiplesBelow_3()
        {
            var sum = eulerProblem001.Solution(3);
            Assert.Equal(0, sum);
        }
    }
}
