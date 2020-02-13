using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem025
    {



        public int ComputeFibonacci()
        {
            int iterationIndex = 3;

            BigInteger sum = 0;
            BigInteger previous = 1;
            BigInteger current = 2;

            if (iterationIndex < 1)
            {
                sum = 0;
            }
            else if (iterationIndex == 1)
            {
                sum = 1;
            }
            else if (iterationIndex == 2)
            {
                sum = 1;
            }
            else
            {
                while(sum < BigInteger.Pow(10, 999))
                {
                    sum = previous + current;
                    Console.WriteLine(sum.ToString().Length);
                    previous = current;
                    current = sum;
                    iterationIndex++;

                }
            }
            

            return iterationIndex;

        }

    }
}
