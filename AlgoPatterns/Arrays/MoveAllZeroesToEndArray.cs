using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Arrays
{
    internal class MoveAllZeroesToEndArray
    {
        public void MoveZerosToTheEnd(int[] arr)
        {
            int low = 0;
            int high = 1;
            while (high < arr.Length)
            {
                if (arr[low] > arr[high] && arr[high] == 0)
                {
                    low++;
                    high++;
                }
                else if (arr[low] > 0 && arr[high] > 0)
                {
                    low++;
                    high++;
                }
                else if (arr[low] == arr[high])
                {
                    high++;
                }
                else
                {
                    Swap(low, high, arr);
                }
            }
        }
        public void Swap(int low, int high, int[] arr)
        {
            int temp = arr[low];
            arr[low] = arr[high];
            arr[high] = temp;
        }
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
