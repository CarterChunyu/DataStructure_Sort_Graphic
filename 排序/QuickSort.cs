using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    public class QuickSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            Sort(arr, 0, n - 1);
        }

        private static void Sort(int[] arr, int i, int j)
        {
            if (i >= j)
                return;            

            int l = i;
            int r = j + 1;
            int c = arr[l];
            for (int k = l+1; k < r; k++)
            {
                if (arr[k] < c)
                {
                    l++;
                    Swap(arr, k, l);
                }
                if (arr[k] > c)
                {
                    r--;
                    Swap(arr, k, r);
                    k--;
                }
            }
            Swap(arr, l, i);
            l--;
            Sort(arr, i, l);
            Sort(arr, r, j);
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
