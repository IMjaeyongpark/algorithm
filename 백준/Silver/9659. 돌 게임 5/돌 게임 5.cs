using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        string s = "SK";
        int check = 0;
        BigInteger a = N/3;
        if (a % 2 == 0) check++;
        if ((N % 3) % 2 == 1) check++;
        if (check % 2 == 1) s = "CY";
        Console.WriteLine(s);

    }
}