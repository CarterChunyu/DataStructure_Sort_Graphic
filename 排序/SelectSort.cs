using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    public class SelectSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int c = arr[i];
                int index = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < c)
                    {
                        c = arr[j];
                        index = j;
                    }
                }
                Swap(arr, i, index);
            }   
        }

        private static void Swap(int[] arr, int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
