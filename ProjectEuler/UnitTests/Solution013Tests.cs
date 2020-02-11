using ProjectEuler.ProjectEulerSolutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class Solution013Tests
    {
        private readonly EulerProblem013 eulerProblem013;

        public Solution013Tests()
        {
            this.eulerProblem013 = new EulerProblem013();
        }

        [Fact]
        public void ShowFirstTenDigits()
        {
            var firstDigits = eulerProblem013.BigIntegerSum();
            Assert.Equal("5537376230", firstDigits);

        }

    }
}
