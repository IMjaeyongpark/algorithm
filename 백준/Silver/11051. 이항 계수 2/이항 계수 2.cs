using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        BigInteger[] nk = new BigInteger[1001];
        nk[0] = 1;
        for(int i = 1; i < 1001; i++)
        {
            nk[i] = nk[i - 1] * i;
        }
        int N = int.Parse(s[0]);
        int K = int.Parse(s[1]);
        BigInteger a = nk[N];
        BigInteger b = nk[K];
        BigInteger c = nk[N - K];

        Console.WriteLine((a / b / c) % 10007);
    }
}