using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class TestSearch
    {
        public static int[] ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<int> nums = new List<int>();
            while (!sr.EndOfStream)
            {
                int num = int.Parse(sr.ReadLine());
                nums.Add(num);
            }
            fs.Close();
            sr.Close();
            return nums.ToArray();
        }

        public static int OrderSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (target == arr[i])
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int l = 0;
            int r = arr.Length;
            int mid = (r - l) / 2 + l;

            while (l <= r)
            {
                if (target == arr[mid])
                    return mid;
                else if (target > arr[mid])
                    l = mid + 1;
                else // target < arr[mid]
                    r = mid - 1;
            }
            return -1;
        }
    }
}
