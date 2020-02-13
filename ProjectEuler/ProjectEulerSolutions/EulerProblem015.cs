using System.Numerics;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem015
    {

        //in a n x n grid you need n steps down and n steps right. So here we can choose a combination without repetition.
        //That means we can compute all possible ways through a n x n grid with n + n choose n. (Or in a n x m grid n + m choose n which is 
        //the same as n + m choose m).

        public BigInteger BinomialCoefficient(int n, int m)
        {
            return ComputeFaculty(n + m) / (ComputeFaculty(n) * ComputeFaculty(m));

        }

        public BigInteger ComputeFaculty(int number)
        {
            BigInteger faculty = 1;
            for(int i = 1; i <= number; i++)
            {
                faculty *= i;
            }
            return faculty;
        }
    }
}
