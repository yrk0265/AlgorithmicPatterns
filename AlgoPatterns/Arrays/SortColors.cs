using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Arrays
{
    internal class SortColors
    {
        private int[] _arr;
        public SortColors(int[] arr)
        {
            _arr = arr;
        }
        public void SortColorArray()
        {
            int low = 0;
            int high = _arr.Length - 1;
            int mid = 0;
            while (high > mid)
            {
                mid = (low + high) / 2;
                if (_arr[mid] == 0)
                {
                    Swap(low, mid, _arr);
                    low++;
                    mid++;
                }
                else if (_arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    Swap(mid, high, _arr);
                    high--;
                }
            }
        }
        private void Swap(int lowormid, int highormid, int[] arr)
        {
            int temp;
            temp = arr[lowormid];
            arr[lowormid] = arr[highormid];
            arr[highormid] = temp;
        }
    }
}
