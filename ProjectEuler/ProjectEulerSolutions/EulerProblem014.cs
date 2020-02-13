using System;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem014
    {

        public long ComputeLongestCollatzSequenz()
        {
            int collatzSequenceLength;
            int largestCollatzSequence = 0;
            long longestNumber = 0;
            int startingNumber = 13;

            while(startingNumber < 1000000)
            {
                startingNumber++;
                collatzSequenceLength = ComputeCollatzLength(startingNumber);

                if(collatzSequenceLength > largestCollatzSequence)
                {
                    largestCollatzSequence = collatzSequenceLength;
                    longestNumber = startingNumber;
                    Console.WriteLine(longestNumber);
                }
                
      
            }
            return longestNumber;
        }
        private int ComputeCollatzLength(long number)
        {
            int collatzSequenceLength = 0;
            while(number != 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                    collatzSequenceLength++;
                }
                else
                {
                    number = 3 * number + 1;
                    collatzSequenceLength++;
                }
            }

            return collatzSequenceLength;
        }
    }
}
