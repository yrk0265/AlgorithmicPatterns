using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactProject
{
    internal class NumericFullPyramid
    {
        public void FullPyramid(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                //spaces
                for (int spaces = 0; spaces < n - rows - 1; spaces++)
                {
                    Console.Write(" ");
                }
                int start = 1;
                //number hollow pyramid
                for (int hollowpy = 0; hollowpy < 2 * rows + 1; hollowpy++)
                {
                    if (rows == 0 || rows == n - 1)
                    {
                        if (hollowpy % 2 == 0)
                        {
                            //even
                            Console.Write(start);
                            start = start + 1;
                        }
                        else
                        {
                            //odd
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (hollowpy == 0)
                        {
                            Console.Write(1);
                        }
                        else if (hollowpy == 2 * rows + 1 - 1)
                        {
                            Console.Write(rows + 1);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
        }
    }
}
