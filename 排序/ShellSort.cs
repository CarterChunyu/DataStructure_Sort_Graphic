using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    public class ShellSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            int step = n / 2;

            while(step >= 1)
            {
                for (int i = 0; i < step; i++)
                {
                    // 插入排序
                    for (int j = i+step; j < n; j= j+step)
                    {
                        int c = arr[j];
                        int index = j;
                        for (int k = j-step; k >= 0 ; k = k-step)
                        {
                            if (arr[k] > c)
                            {
                                arr[k + step] = arr[k];
                                index = k;
                            }
                            else
                                break;
                        }
                        arr[index] = c;
                    }
                }
                step = step / 2;
            }
        }
    }
}
