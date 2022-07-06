using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        Console.WriteLine(BigInteger.Parse(s[0]) * BigInteger.Parse(s[1]));
    }
}