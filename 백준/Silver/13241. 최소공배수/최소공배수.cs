using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        BigInteger a = BigInteger.Parse(s[0]);
        BigInteger b = BigInteger.Parse(s[1]);
        int n1 = 1;
        int n2 = 1;
        while (a*n1 != b*n2)
        {
            if (a*n1 < b*n2)
            {
                n1++;
            }
            else if (a*n1 > b*n2)
            {
                n2++;
            }
        }
        Console.WriteLine(a*n1); 
    }
}