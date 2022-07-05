using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine((a + b) + "\n" + (a - b) + "\n" + (a * b));
    }
}