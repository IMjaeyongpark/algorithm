using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = (a + b) / 2;
        BigInteger d = a >= b ? a - c : a - c;
        Console.WriteLine(c);
        Console.WriteLine(d);
        
    }
}