using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem007
    {
        public long CountPrimeNumbers(long position)
        {
            int primePosition = 0;
            int numberToCheck = 1;

            while (primePosition < position)
            {
                numberToCheck++;

                if (IsPrime(numberToCheck))
                {
                    primePosition++;
                }
            }

            return numberToCheck;
        }

        private bool IsPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (long i = 5; i * i <= number; i = i + 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
