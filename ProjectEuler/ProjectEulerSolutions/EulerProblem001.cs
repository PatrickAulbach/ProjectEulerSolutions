namespace ProjectEuler
{
    class EulerProblem001
    {
        public int Solution(int threshold)
        {
            int sum = 0;
            for(int i = 0; i < threshold; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
