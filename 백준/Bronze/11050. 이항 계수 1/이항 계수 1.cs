using System;

class Program
{
    static int nk(int a)
    {
        if (a <= 1) return 1;

        return a * nk(a - 1);
    }
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int K = int.Parse(s[1]);
        int a = nk(N);
        int b = nk(K);
        int c = nk(N-K);
        Console.WriteLine(a/b/c);
    }
}