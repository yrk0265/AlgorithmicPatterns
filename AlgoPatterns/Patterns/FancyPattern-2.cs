using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Patterns
{
    internal class FancyPattern_2
    {
        public void FancyPattern(int n)
        {
            //numbers
            for (int rows = 0; rows < n; rows++)
            {
                for (int numbers = 0; numbers < 2 * rows + 1; numbers++)
                {
                    if (numbers % 2 == 0)
                    {
                        Console.Write(rows + 1 + " ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            for (int rows = 0; rows < n; rows++)
            {
                for (int numbers = 0; numbers < 2 * n - 2 * rows - 1; numbers++)
                {
                    if (numbers % 2 == 0)
                    {
                        Console.Write(n - rows + " ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
