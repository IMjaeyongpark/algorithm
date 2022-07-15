using System;
using System.Numerics;

class Program
{
    static BigInteger pac(int N)
    {
        if (N <= 1) return 1;
        return N * pac(N - 1);
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        BigInteger a = pac(N);
        string s = a.ToString();
        char[] c = s.ToCharArray();
        int count = 0;
        for (int i = c.Length - 1; c[i] == '0'; i--)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}