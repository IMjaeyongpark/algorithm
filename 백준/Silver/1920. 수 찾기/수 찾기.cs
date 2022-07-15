using System;
using System.Text;

class Program
{
    static int[] a;
    static int insect(int start, int end, int key)
    {
        int b = start + (end - start) / 2;
        if (end - start >= 0)
        {
            if (a[b] == key) return 1;
            else if (a[b] < key) return insect(b + 1, end, key);
            else return insect(start, b - 1, key);
        }
        else return 0;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        a = new int[N];
        string[] s = Console.ReadLine().Split();
        for (int i = 0; i < N; i++)
        {
            a[i] = int.Parse(s[i]);
        }


        Array.Sort(a);
        int M = int.Parse(Console.ReadLine());
        string[] s1 = Console.ReadLine().Split();

        for (int i = 0; i < M; i++)
        {
            int k = int.Parse(s1[i]);
            sb.Append(insect(0, N - 1, k) + "\n");
        }
        Console.WriteLine(sb);
    }
}