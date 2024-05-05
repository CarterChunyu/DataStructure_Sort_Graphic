using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    public class MergeSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            Sort(arr, temp, 0, n - 1);
        }
        private static void Sort(int[] arr, int[] temp, int i, int j)
        {
            if (i >= j)
                return;

            int mid = i + (j - i) / 2;
            Sort(arr, temp, i, mid);
            Sort(arr, temp, mid + 1, j);
            Merge(arr, temp, i, j, mid);
        }

        private static void Merge(int[] arr, int[] temp, int i, int j, int mid)
        {
            int a = i;
            int b = mid+1;
            int c = i;

            while (c <= j)
            {
                if(a <= mid && b <=j)
                {
                    if (arr[a] <= arr[b])
                        temp[c++] = arr[a++];
                    else
                        temp[c++] = arr[b++];
                    continue;
                }

                if(a <= mid)
                    temp[c++] = arr[a++];

                if (b <= j)
                    temp[c++] = arr[b++];
            }

            for (int k = i; k <= j; k++)
            {
                arr[k] = temp[k];
            }
        }
    }
}
