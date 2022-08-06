using System;

class Program
{
    static int[] sc;
    static int N;
    static int[] f0;
    static int[] f1;

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        sc = new int[N];
        for(int i = 0; i < N; i++)
        {
            sc[i] = int.Parse(Console.ReadLine());
        }
        f0 = new int[N];
        f1 = new int[N];
        for(int j = 0; j < N; j++)
        {
            f0[j] = sc[j] + (j - 2 >= 0 ? (f0[j - 2] >= f1[j - 2] ? f0[j - 2] : f1[j - 2]) : 0);
            f1[j] = sc[j] + (j - 1 >= 0 ? f0[j - 1] : 0);
        }
        Console.WriteLine(f0[N - 1] >= f1[N - 1] ? f0[N - 1] : f1[N - 1]);
    }
}