namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem010
    {

        public long SumOfPrimes(int numOfPrimes)
        {
            long sumOfPrimes = 0;
            for(int i = 2; i < numOfPrimes; i++)
            {
                if(IsPrime(i))
                {
                    sumOfPrimes += i;
                }
            }
            return sumOfPrimes;
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
