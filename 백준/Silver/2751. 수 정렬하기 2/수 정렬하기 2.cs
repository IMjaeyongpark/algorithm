using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int[] a = new int[N];
        for(int i = 0; i < N; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(a);
        for(int i =0; i < N; i++)
        {
            sb.Append(a[i] + "\n");
        }
        Console.WriteLine(sb);
    }
}