using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        BigInteger a = BigInteger.Parse(s[0]);
        for (int i = 0; i < s[1].Length; i++) a *= 10;
        a+=BigInteger.Parse(s[1]);
        BigInteger b = BigInteger.Parse(s[2]);
        for (int i = 0; i < s[3].Length; i++) b *= 10;
        b += BigInteger.Parse(s[3]);
        Console.WriteLine(a + b);
        
    }
}