using ProjectEuler.ProjectEulerSolutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution008Tests
    {
        private readonly EulerProblem008 eulerProblem008;

        public Solution008Tests()
        {
            this.eulerProblem008 = new EulerProblem008();
        }

        [Fact]
        public void FindLargestProductForStride_4()
        {
            long largestProduct = eulerProblem008.FindLargestProduct(4);
            Assert.Equal(5832, largestProduct);
        }

        [Fact]
        public void FindLargestProductForStride_13()
        {
            long largestProduct = eulerProblem008.FindLargestProduct(13);
            Assert.Equal(23514624000, largestProduct);
        }
    }
}
