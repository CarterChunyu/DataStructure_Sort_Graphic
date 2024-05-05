using System.Reflection;


int[] arr = new int[] { 7, 5, 1, 13, 5, 5, 2, 7, 98, 18, 8, 6, 2, 4, 6, 9, 55, 66, 44, 23, 19 };

Assembly assembly = Assembly.Load("排序");
string className = Console.ReadLine();
Type type = assembly.GetType($"排序.{className}");
MethodInfo methodInfo = type.GetMethod("Sort");
methodInfo.Invoke(null, new object[] {arr});

Console.WriteLine(string.Join(",", arr));