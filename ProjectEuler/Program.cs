using ProjectEuler.ProjectEulerSolutions;
using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] grid2D = new int[2, 3]
            {
                {1, 1, 1},
                {2, 2, 2}
            };

            Console.WriteLine(grid2D.GetLength(0));
            Console.WriteLine(grid2D.GetLength(1));
        }
    }
}
