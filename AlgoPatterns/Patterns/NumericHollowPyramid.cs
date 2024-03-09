using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AlgorithmProject.Patterns
{
    internal class NumericHollowPyramid
    {
        public void NHP(int n)
        {
            int start = 1;
            for (int rows = 0; rows < n; rows++)
            {
                //spaces
                for (int spaces = 0; spaces < n - rows - 1; spaces++)
                {
                    Console.Write("  ");
                }
                //numbers
                for (int numbers = 0; numbers < 2 * rows + 1; numbers++)
                {
                    if (numbers == 0 && rows != n - 1)
                        Console.Write(1);
                    if (rows > 0 && numbers > 0)
                    {
                        if (numbers < 2 * rows - 1 + 1)
                        {
                            Console.Write("  ");
                        }
                        if (numbers == 2 * rows - 1)
                        {
                            Console.Write(rows + 1);
                        }
                    }
                    if (rows == n - 1 && start <= n)
                    {
                        Console.Write(start + " ");
                        start = start + 1;

                    }
                    if (start == n + 1)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
