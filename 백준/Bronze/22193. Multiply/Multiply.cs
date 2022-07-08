using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        BigInteger M = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(N * M);
    }
}