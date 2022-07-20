using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        BigInteger[] km = Array.ConvertAll(s, BigInteger.Parse);
        string[] s1 = Console.ReadLine().Split();
        BigInteger[] price = Array.ConvertAll(s1, BigInteger.Parse);
        BigInteger sum = 0;
        BigInteger min = 1000000001;
        for(int i = 0; i < N-1; i++)
        {
            if (min > price[i]) min = price[i];
            sum += km[i] * min;
        }
        Console.WriteLine(sum);
    }
}