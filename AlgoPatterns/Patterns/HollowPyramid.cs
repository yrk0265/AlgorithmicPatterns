using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Patterns
{
    internal class HollowPyramid
    {
        public void HPyramid(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                //spaces
                for (int spaces = 0; spaces < n - rows - 1; spaces++)
                {
                    Console.Write(" ");
                }
                //starts
                for (int stars = 0; stars < 2 * rows + 1; stars++)
                {
                    if (stars == 0 || stars == 2 * rows)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int rows = 0; rows < n; rows++)
            {
                //spaces
                for (int spaces = 0; spaces < rows; spaces++)
                {
                    Console.Write(" ");
                }
                //stars
                for (int stars = 0; stars < 2 * n - (2 * rows - 1); stars++)
                {
                    if (stars == 0 || stars == 2 * n - 2 * rows - 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
