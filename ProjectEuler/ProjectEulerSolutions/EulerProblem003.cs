namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem003
    {
        public long Solution(long number)
        {
            long highestPrimeFactor = 0;
            for(long i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    bool isPrime = IsPrime(i);
                    if(isPrime)
                    {
                        highestPrimeFactor = i;
                    }
                    number /= i;
                }
            }
            return highestPrimeFactor;
        }

        // this method should check if a number is prime. We test all numbers from 5 to sqrt(number) and only cases where 6*n 
        public bool IsPrime(long number)
        {
            if(number <= 1)
            {
                return false;
            } 
            if(number <= 3)
            {
                return true;
            }
            if(number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for(long i = 5; i*i <= number; i = i + 6)
            {
                if(number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
