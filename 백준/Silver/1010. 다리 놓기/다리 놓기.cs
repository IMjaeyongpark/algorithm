using System;
using System.Text;
using System.Numerics;

class Program
{
    static BigInteger pac(int N,int i)
    {
        if (N <= i) return 1;
        else return pac(N - 1, i) * N;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(Console.ReadLine());
        for(int i = 0; i < T; i++)
        {
            string[] s = Console.ReadLine().Split();
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            sb.Append(pac(M, M - N) / pac(N, 1) + "\n");
        }
        Console.WriteLine(sb);
    }
}