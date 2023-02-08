using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject
{
    internal class FlippedSolidDiamond
    {
        public void FlippedSD(int n)
        {
            //stars
            for (int rows = 0; rows < n; rows++)
            {
                for (int stars = 0; stars < n-rows; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
