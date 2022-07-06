using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        BigInteger a = BigInteger.Parse(s[0]);
        BigInteger b = BigInteger.Parse(s[1]);
        Console.WriteLine(a + b);
    }
}