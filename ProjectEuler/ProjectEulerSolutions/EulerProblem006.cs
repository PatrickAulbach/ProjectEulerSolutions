using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.ProjectEulerSolutions
{
    class EulerProblem006
    {
        private long naturalNumber;

        public EulerProblem006(long naturalNumber)
        {
            this.naturalNumber = naturalNumber;
        }

        public long SumSquareDifference()
        {
            return ComputeSquareOfSum() - ComputeSumOfSquares();
        }
        public long ComputeSumOfSquares()
        {
            return ((this.naturalNumber * (this.naturalNumber + 1) * (2 * this.naturalNumber + 1)) / 6);
        }

        public long ComputeSquareOfSum()
        {
            return (long) Math.Pow(((this.naturalNumber * (this.naturalNumber + 1)) / 2), 2);
        }

        public long NaturalNumber
        {
            set { naturalNumber = value; }
        }
    }
}
