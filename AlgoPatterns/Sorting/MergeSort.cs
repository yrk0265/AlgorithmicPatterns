

namespace AlgorithmProject.Sorting
{
    public class MergeSort
    {
        private int[] _array;
        public MergeSort(int[] array)
        {
            _array = array;
        }
        public void Sort()
        {
            MergeSortRecursive(_array, 0, _array.Length - 1);
        }
        private static void MergeSortRecursive(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSortRecursive(arr, left, middle);
                MergeSortRecursive(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }
        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[middle + 1 + j];

            int k = left;
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    arr[k] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[k] = rightArray[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < n1)
            {
                arr[k] = leftArray[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < n2)
            {
                arr[k] = rightArray[rightIndex];
                rightIndex++;
                k++;
            }
        }
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
