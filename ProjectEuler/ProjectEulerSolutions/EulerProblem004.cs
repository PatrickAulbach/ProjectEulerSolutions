using System;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem004
    {
        public int Solution(long number)
        {
            return 0;


        }

        public bool CheckPalindrome(long number)
        {
            string numToString = number.ToString();

            for(int i = 0; i < Math.Floor((double) numToString.Length / 2); i++)
            {
                if(numToString[i] != numToString[numToString.Length - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
