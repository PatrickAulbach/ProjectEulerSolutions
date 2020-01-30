namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem005
    {
        private int maxDivisor;
        private long startNumber;

        public EulerProblem005(int maxDivisor, long startNumber)
        {
            this.maxDivisor = maxDivisor;
            this.startNumber = startNumber;
        }

        public long FindSmallestNumber()
        {
            long smallestNumber = this.startNumber;
            bool foundSmallesNumber = false;
            while (!foundSmallesNumber)
            {
                smallestNumber++;
                foundSmallesNumber = IsEvenlyDivisible(smallestNumber);
            }
            return smallestNumber;
        }

        private bool IsEvenlyDivisible(long number)
        {
            for(int i = 1; i <= this.maxDivisor; i++)
            {
                if(number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public long StartNumber
        {
            set { startNumber = value; }
        }

        public int MaxDivisor
        {
            set { maxDivisor = value; }
        }
    }
}
