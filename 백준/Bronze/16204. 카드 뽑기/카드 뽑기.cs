using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int K = int.Parse(s[2]);
        int sum = 0;
        if (M <= K) sum += M;
        else sum += K;
        if (N - M <= N - K) sum += N - M;
        else sum += N - K;
        Console.WriteLine(sum);
    }
}