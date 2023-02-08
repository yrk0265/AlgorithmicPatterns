using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject
{
    internal class PrintAllPrimeNumbers
    {
        public void PrimeNumbers(int n)
        {
            for (int row = 2; row < n; row++)
            {
                int Count = 0;
                for (int col = 1; col <= row; col++)
                {
                    if (Count > 3)
                        break;
                    if (row % col == 0)
                    {
                        Count++;
                    }
                }
                if (Count==2)
                {
                    Console.Write(row + " ");
                }
            }
            Console.Read();
        }
    }
}
