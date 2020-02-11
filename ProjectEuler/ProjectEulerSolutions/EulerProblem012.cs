using System;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem012
    {
        private long triangleNumber;
       
        public long CheckTriangleNumber(int maxDivisors)
        {
            int iteration = 1;
            int numDivisors = 0;
            
            while(numDivisors < maxDivisors)
            {
                numDivisors = 0;
                this.triangleNumber = ComputeTriangleNumber(iteration);
                numDivisors = CountDivisors(triangleNumber);

                iteration++;
            }

            return this.triangleNumber;
        }

        public int CountDivisors(long triangleNumber)
        {
            int numDivisors = 0;
            int triangleSquareRoot = (int) Math.Sqrt(triangleNumber);
            for (int i = 1; i <= triangleSquareRoot; i++)
            {
                if (triangleNumber % i == 0)
                {
                    numDivisors += 2;
                }
            }

            if(triangleSquareRoot * triangleSquareRoot == triangleNumber)
            {
                numDivisors++;
            }
            return numDivisors;
        }

        public long ComputeTriangleNumber(int iteration)
        {
            long triangleNumber = 0;
            for(int i = 1; i <= iteration; i++)
            {
                triangleNumber += i;
            }
            return triangleNumber;
        }

    }
}
