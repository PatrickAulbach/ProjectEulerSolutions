using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem002
    {
        public int Solution(int n)
        {
            int sum = 0;
            int previous = 1;
            int current = 2;

            if(n < 1)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else if(n == 2)
            {
                return 1;
            }
            else
            {
                for(int i = 3; i < n; i++)
                {
                    sum = previous + current;
                    previous = current;
                    current = sum;
                }
                return sum;
            }
        }
    }
}
