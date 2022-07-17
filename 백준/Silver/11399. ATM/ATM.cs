using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        int[] a = new int[N];
        for(int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(s[i]);
        }
        Array.Sort(a);
        int sum = 0;
        for(int j = 0; j < a.Length; j++)
        {
            sum += a[j] * (N - j);
        }
        Console.WriteLine(sum);
    }
}