using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject
{
    internal class DetermineifPrimeNumbers
    {
        public bool PrintPrimeNumbers(int n)
        {
            if (n <= 1)
                return false;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
