using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
    //int[] generalCustomers = TestSearch.ReadFile("測試文件2/遊戲用戶表.txt");
    //int[] members = TestSearch.ReadFile("測試文件2/遊戲會員表.txt");

    //List<int> user1 = new List<int>();
    //Stopwatch t1 = new Stopwatch();
    //t1.Start();
    //for (int i = 0; i < generalCustomers.Length; i++)
    //{
    //    if (TestSearch.OrderSearch(members, generalCustomers[i]) != -1)
    //        user1.Add(generalCustomers[i]);
    //}
    //t1.Stop();
    //Console.WriteLine(user1.Count);
    //Console.WriteLine(t1.ElapsedMilliseconds);

    //List<int> user2 = new List<int>();
    //Stopwatch t2 = new Stopwatch();
    //t2.Start();
    //Array.Sort(members);
    //for (int i = 0; i < generalCustomers.Length; i++)
    //{
    //    if (TestSearch.BinarySearch(members, generalCustomers[i]) == -1)
    //        user2.Add(generalCustomers[i]);
    //}
    //t2.Stop();
    //Console.WriteLine(user2.Count);
    //Console.WriteLine(t2.ElapsedMilliseconds);

    //int[] arr = { 84, 84,48, 68, 10, 18, 98, 12, 23, 54, 57, 33, 16, 77, 11, 29 };
    //SortedArray1<int> sortedArray1 = new SortedArray1<int>();
    //for (int i = 0; i < arr.Length; i++)
    //{
    //    sortedArray1.Add(arr[i]);
    //}
    //Console.WriteLine(sortedArray1);
    //Console.WriteLine(sortedArray1.Min());
    //Console.WriteLine(sortedArray1.Select(5));
    //Console.WriteLine(sortedArray1.Floor(15));
    //Console.WriteLine(sortedArray1.Ceiling(15));
    //sortedArray1.Remove(23);
    //Console.WriteLine(sortedArray1);


    //List<string> words = TestHelper.ReadFile("測試文件1/雙城記.txt");
    //Console.WriteLine(words.Count);

    //SortedArray1Set<string> sortedArray1Set = new SortedArray1Set<string>();
    //Console.WriteLine(TestObj.TestSet(sortedArray1Set, words));
    //Console.WriteLine(sortedArray1Set.Count);

    //SortedArray2Dictionary<string, int> dic = new 資料結構.SortedArray2Dictionary<string, int>();
    //Console.WriteLine(TestObj.TestDiciotnary(dic, words));
    //Console.WriteLine(dic.Count);
    //Console.WriteLine(dic.Get("city"));
}
#endregion
#region 二差樹
{
    //int[] arr = { 5, 3, 7, 9, 1, 4, 8, 12, 3 };
    //BST1<int> bST1 = new BST1<int>();
    //for (int i = 0; i < arr.Length; i++)
    //{
    //    bST1.Add(arr[i]);
    //}
    ////Console.WriteLine(bST1.Count);
    ////bST1.PreOrder();
    //bST1.Remove(45);
    //Console.WriteLine("---");
    //bST1.InOrder();
    //Console.WriteLine("---");
    ////bST1.Remove(7);
    //bST1.PreOrder();
    //Console.WriteLine("---");
    //Console.WriteLine(bST1.Rank(7));
    //Console.WriteLine(bST1.Rank(13));
    //Console.WriteLine(bST1.Rank(12));
    //Console.WriteLine(bST1.Rank(0));
    //Console.WriteLine("---");
    //Console.WriteLine(bST1.Select(3));
    ////Console.WriteLine(bST1.Ceiling(13));
    //Console.WriteLine(bST1.Ceiling(6));
    //Console.WriteLine(bST1.Floor(6));
    ////Console.WriteLine(bST1.Floor(0));
    //Console.WriteLine(bST1.MaxHeight());
    //Console.WriteLine("---");
    //bST1.PostOrder();
    //Console.WriteLine(bST1.Contains(7));
    //Console.WriteLine(bST1.Contains(14));

    //List<string> words = TestHelper.ReadFile("測試文件1/雙城記.txt");
    //Console.WriteLine(words.Count);

    //BST1Set<string> bST1Set = new BST1Set<string>();
    //Console.WriteLine(TestObj.TestSet(bST1Set, words));
    //Console.WriteLine(bST1Set.Count);

    //BST2Dictionary<string, int> dic = new 資料結構.BST2Dictionary<string, int>();
    //Console.WriteLine(TestObj.TestDiciotnary(dic, words));
    //Console.WriteLine(dic.Count);
    //Console.WriteLine(dic.Get("city"));


}
#endregion
#region 紅黑樹
{
    //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    //RBT1<int> rBT1 = new RBT1<int>();
    //for (int i = 0; i < nums.Length; i++)
    //    rBT1.Add(nums[i]);
    //Console.WriteLine(rBT1.MaxHeight());


    //List<string> words = TestHelper.ReadFile("測試文件1/雙城記.txt");
    //Console.WriteLine(words.Count);

    //BST1Set<string> bST1Set = new BST1Set<string>();
    //Console.WriteLine(TestObj.TestSet(bST1Set, words));
    //Console.WriteLine(bST1Set.Count);

    //RBT2Dictionary<string, int> dic = new 資料結構.RBT2Dictionary<string, int>();
    //Console.WriteLine(TestObj.TestDiciotnary(dic, words));
    //Console.WriteLine(dic.Count);
    //Console.WriteLine(dic.Get("city"));

}
#endregion
#region 哈希表
{
    List<string> words = TestHelper.ReadFile("測試文件1/雙城記.txt");
    Console.WriteLine(words.Count);

    HashSt1Set<string> hashSt1Set = new HashSt1Set<string>();
    Console.WriteLine(TestObj.TestSet(hashSt1Set, words));
    Console.WriteLine(hashSt1Set.Count);

    HashSt2Dictionary<string, int> dic = new 資料結構.HashSt2Dictionary<string, int>();
    Console.WriteLine(TestObj.TestDiciotnary(dic, words));
    Console.WriteLine(dic.Count);
    Console.WriteLine(dic.Get("city"));
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

    public static long TestSet(Iset<string> set, List<string> words)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        foreach (var word in words)
            set.Add(word);
        sw.Stop();
        return sw.ElapsedMilliseconds; 
    }

    public static long TestDiciotnary(Idictionary<string,int> dic, List<string> words)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        foreach (var word in words)
        {
            if(dic.ContainsKey(word))
            {
                dic.Set(word, dic.Get(word)+1);
            }
            else
            {
                dic.Add(word, 1);
            }
        }
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}


