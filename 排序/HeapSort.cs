using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    public class HeapSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = (n-1-1)/2; i >= 0; i--)
            {
                Sink(arr, i, n - 1);
            }

            for (int i = n-1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                Sink(arr, 0, i - 1);
            }
        }

        private static void Sink(int[] arr, int index, int max)
        {
            while(index *2 +1 <= max)
            {
                int c_index = index * 2 + 1;
                if (c_index + 1 <= max && arr[c_index + 1] > arr[c_index])
                    c_index++;
                if (arr[index] >= arr[c_index])
                    break;
                Swap(arr, index, c_index);
                index = c_index;
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
