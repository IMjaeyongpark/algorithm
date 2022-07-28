using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] a = new int[N];
        int count = 0;
        int dasom = int.Parse(Console.ReadLine());
        for (int i = 0; i < N - 1; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        while (true)
        {
            int idx = Array.IndexOf(a, a.Max());
            if (dasom > a[idx]) break;
            count++;
            a[idx]--;
            dasom++;
        }
        Console.WriteLine(count);
    }
}