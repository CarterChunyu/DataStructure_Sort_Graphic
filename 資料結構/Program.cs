using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using 資料結構;

#region 數組
{
    //	int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //	Array1<int> arr1 = new Array1<int>();
    //	for (int i = 0; i < nums.Length; i++)
    //		arr1.Add(i, nums[i]);

    //	arr1.AddFirst(0);
    //	arr1.AddLast(15);
    //    Console.WriteLine(arr1.ToString());

    //	arr1.RemoveAt(5);
    //    Console.WriteLine(arr1.ToString());

    //	arr1.Remove(7);
    //    Console.WriteLine(arr1.ToString());

    //	// 裝箱 值類型轉換成引用類型
    //	// 拆箱 引用類型轉換成值類型
    //	// 引用類型: 任何稱為類的都是引用類型, 使用 class 修飾 => string、object
    //	// 值類型: 所有值類型都稱為結構或枚舉, 使用 struct 或 enum 修飾 int、float、double、char

    //	ArrayList a = new ArrayList();
    //	for (int i = 0; i < 1000000; i++)
    //	{
    //		// 裝箱
    //		a.Add(i);
    //		// 拆箱 
    //		int x = (int)a[i];
    //	}

}
# endregion
#region 鏈表
{
    //   int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };

    //LinkedList1<int> l = new LinkedList1<int>();
    //for (int i = 0; i < nums.Length; i++)
    //{
    //	l.AddLast(nums[i]);
    //}
    //   Console.WriteLine(l);

    //l.AddFirst(666);
    //l.Add(4, 555);
    //   Console.WriteLine(l);

    //l.RemoveAt(5);
    //l.Set(0, 777);
    //   Console.WriteLine(l);

    //l.Remove(777);
    //l.Remove(2);
    //l.Remove(6);
    //   Console.WriteLine(l);
}
#endregion
#region 棧和隊列
{
    //int N = 200000;
    //Array1Stack<int> array1Stack = new Array1Stack<int>();
    //Console.WriteLine(TestObj.TestStack(array1Stack,N));

    //LinkedList1Stack<int> linkedList1Stack = new LinkedList1Stack<int>();
    //Console.WriteLine(TestObj.TestStack(linkedList1Stack, N));

    //Array2<int> arr2 = new Array2<int>();
    //for (int i = 0; i <15; i++)
    //{
    //    arr2.Add(i);
    //}
    //Console.WriteLine(arr2);
    //for (int i = 0; i < 15; i++)
    //{
    //    Console.WriteLine(arr2.Remove());
    //}
    //Console.WriteLine(arr2);
    //for (int i = 15; i < 20; i++)
    //{
    //    arr2.Add(i);
    //}
    //Console.WriteLine(arr2);

    //Array1Queue<int> array1Queue = new Array1Queue<int>();
    //Console.WriteLine(TestObj.TestQueue(array1Queue, N));

    //Array2Queue<int> array2Queue = new Array2Queue<int>();
    //Console.WriteLine(TestObj.TestQueue(array2Queue,N));

    //LinkedList2<int> l = new LinkedList2<int>();
    //for (int i = 0; i < 10; i++)
    //{
    //    l.AddLast(i);
    //}
    //Console.WriteLine(l);
    //for (int i = 0; i < 10; i++)
    //{
    //    Console.WriteLine(l.RemoveFirst());
    //}
    //l.AddLast(333);
    //Console.WriteLine(l);

    //LinkedList1Queue<int> l1 = new LinkedList1Queue<int>();
    //Console.WriteLine(TestObj.TestQueue(l1, N));

    //LinkedList2Queue<int> l2 = new LinkedList2Queue<int>();
    //Console.WriteLine(TestObj.TestQueue(l2, N));

}
#endregion
#region 集合與映射
{
    
    //List<string> words = TestHelper.ReadFile("測試文件1/雙城記.txt");
    //Console.WriteLine(words.Count);

    //LinkedList1Set<string> linkedList1Set = new LinkedList1Set<string>();
    //Stopwatch t = new Stopwatch();
    //t.Start();
    //foreach (string word in words)
    //{
    //    linkedList1Set.Add(word);
    //}
    //t.Stop();
    //Console.WriteLine(linkedList1Set.Count);
    //Console.WriteLine(t.ElapsedMilliseconds);

    //LinkedList3Dictionary<string, int> ld = new LinkedList3Dictionary<string, int>();
    //Stopwatch t1 = new Stopwatch();
    //t1.Start();
    //foreach (string word in words)
    //{
    //    if (ld.ContainsKey(word))
    //    {
    //        ld.Set(word, ld.Get(word) + 1);
    //    }
    //    else
    //    {
    //        ld.Add(word, 1);
    //    }
    //}
    //t1.Stop();
    //Console.WriteLine(ld.Count);
    //Console.WriteLine(ld.Get("city"));
    //Console.WriteLine(t1.ElapsedMilliseconds);
}
#endregion
#region 有序數組
{
    int[] generalCustomers = TestSearch.ReadFile("測試文件2/遊戲用戶表.txt");
    int[] mebers = TestSearch.ReadFile("測試文件2/遊戲會員表.txt");

    List<int> user1 = new List<int>();
    Stopwatch t1 = new Stopwatch();
    t1.Start();
    for (int i = 0; i < generalCustomers.Length; i++)
    {
        if (TestSearch.OrderSearch(mebers, generalCustomers[i]) != -1)
            user1.Add(generalCustomers[i]);
    }
    t1.Stop();
    Console.WriteLine(user1.Count);
    Console.WriteLine(t1.ElapsedMilliseconds);

    List<int> user2 = new List<int>();
    Stopwatch t2 = new Stopwatch();
    t2.Start();
    for (int i = 0; i < generalCustomers.Length; i++)
    {
        if (TestSearch.BinarySearch(mebers, generalCustomers[i]) != -1)
            user2.Add(generalCustomers[i]);
    }
    t2.Stop();
    Console.WriteLine(user2.Count);
    Console.WriteLine(t2.ElapsedMilliseconds);
}
#endregion


public class TestObj
{
    public static long TestStack(IStack<int> stack, int N)
    {
        Stopwatch t = new Stopwatch();
        t.Start();
        for (int i = 0; i < N; i++)
        {
            stack.Push(i);
        }
        for (int i = 0; i < N; i++)
        {
            stack.Pop();
        }
        t.Stop();
        return t.ElapsedMilliseconds;
    }

    public static long TestQueue(IQueue<int> queue, int N)
    {
        Stopwatch t = new Stopwatch();
        t.Start();
        for (int i = 0; i < N; i++)
        {
            queue.Enqueue(i);
        }
        for (int i = 0; i < N; i++)
        {
            queue.Dequeue();
        }
        t.Stop();
        return t.ElapsedMilliseconds;
    }
}

