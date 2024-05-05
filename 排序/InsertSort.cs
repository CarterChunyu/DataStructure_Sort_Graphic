using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    // 打牌的整理方式
    public class InsertSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int c = arr[i];
                int index = i;
                for (int j = i-1; j >= 0 ; j--)
                {
                    if (arr[j] > c)
                    {
                        arr[j + 1] = arr[j];
                        index = j;
                    }
                    else
                        break;
                }
                arr[index] = c;
            }
        }
    }
}
