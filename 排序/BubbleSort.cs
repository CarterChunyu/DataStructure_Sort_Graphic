using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace 排序
{
    public class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n-1; i >= 0 ; i--)
            {
                for (int j = 0; j < i ; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
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
