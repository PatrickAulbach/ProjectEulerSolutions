using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem009
    {

        public (int, int, int) FindPythagoreanTriplet(int number)
        {
            for(int a = 1; a < number; a++)
            {
                for(int b = 1; b < number; b++)
                {
                    if(a + b + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == number)
                    {
                        return (a, b, (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
                    }
                }
            }

            return (0, 0, 0);
        }

        
    }
}
