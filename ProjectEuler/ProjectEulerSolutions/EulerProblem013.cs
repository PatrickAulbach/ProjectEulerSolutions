using System.IO;
using System.Numerics;


namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem013
    {

        public string BigIntegerSum()
        {

            BigInteger sum = new BigInteger();

            foreach (string line in File.ReadLines(@"D:\Development\C#\ProjectEulerSolutions\ProjectEuler\Assets\Problem013.txt"))
            {
                sum += BigInteger.Parse(line);
            }

            return sum.ToString().Substring(0, 10);
        }
    }
}
