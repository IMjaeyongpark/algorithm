using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        int[] arr = Array.ConvertAll(s, int.Parse);
        int[] data = arr.Distinct().ToArray();
        Array.Sort(data);
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for(int i = 0; i < data.Length; i++)
        {
            dic.Add(data[i], i);
        }
        for(int i = 0; i < arr.Length; i++)
        {
            sb.Append(dic[arr[i]] + " ");
        }
        Console.WriteLine(sb);
    }
}