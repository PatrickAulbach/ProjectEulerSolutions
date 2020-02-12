using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem016
    {

        public BigInteger PowerDigitSum(int number, int power)
        {
            BigInteger sum = 0;
            string exponentiation = ((BigInteger) Math.Pow(number, power)).ToString();
            foreach(char singleDigit in exponentiation)
            {
                sum += (long)Char.GetNumericValue(singleDigit);
            }

            return sum;
        }
    }
}
