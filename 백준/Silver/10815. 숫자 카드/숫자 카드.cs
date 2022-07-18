using System;
using System.Text;


class Program
{
    static int[] a;
    static int search(int start, int end ,int key)
    {
        int mid = (end + start) / 2;
        if (end >= start)
        {
            if (key == a[mid]) return 1;
            else if (key > a[mid]) return search(mid + 1, end, key);
            else return search(start, mid - 1, key);
        }
        return 0;
    }

    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        a = new int[N];
        string[] s = Console.ReadLine().Split();
        for(int i = 0; i < N; i++)
        {
            a[i] = int.Parse(s[i]);
        }
        Array.Sort(a);
        int M = int.Parse(Console.ReadLine());
        string[] s1 = Console.ReadLine().Split();
        for(int j = 0; j < M; j++)
        {
            sb.Append(search(0, a.Length - 1, int.Parse(s1[j]))+" ");
        }
        Console.WriteLine(sb);
    }
}
