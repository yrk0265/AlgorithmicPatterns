using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Patterns
{
    internal class Fancy_Pattern_1
    {
        public void FancyPattern(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                //stars
                for (int stars = 0, row = rows + 2; stars < 2 * n - row - 1; stars++, row = rows + 1)
                {
                    Console.Write("*");
                }
                for (int numbers = 0; numbers < 2 * rows + 1; numbers++)
                {
                    if (numbers % 2 == 0)
                    {
                        Console.Write(rows + 1);
                    }
                    else
                        Console.Write("*");
                }
                //stars
                for (int stars = 0, row = rows + 2; stars < 2 * n - row - 1; stars++, row = rows + 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //for (int rows = 0; rows < n; rows++)
            //{
            //    //numbers

            //    Console.WriteLine();
            //}
        }
    }
}
