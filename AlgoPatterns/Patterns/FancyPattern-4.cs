using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Patterns
{
    internal class FancyPattern_4
    {

        public void Pattern4(int n)
        {
            int start = 0;
            int lastrowfirst = 0;
            for (int rows = 0; rows < n; rows++)
            {
                //numbers
                for (int col = 0; col < rows + 1; col++)
                {
                    start = start + 1;
                    Console.Write(start + " ");
                    if (col < rows)
                        Console.Write("* ");
                    if (rows == 3 && col == 0)
                        lastrowfirst = start;
                }
                Console.WriteLine();
            }
            for (int rows = 0; rows < n; rows++)
            {
                for (int col = 0; col < 2 * n - (2 * rows + 1); col++)
                {
                    if (col % 2 == 0 && rows == 0)
                    {
                        Console.Write(lastrowfirst + " ");
                        lastrowfirst = lastrowfirst + 1;
                    }
                    else if (col % 2 == 0 && rows > 0)
                    {
                        //Console.Write(lastrowfirst + " ");
                        //lastrowfirst = lastrowfirst - 1;
                    }
                    else
                        Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
