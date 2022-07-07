using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        for(int i = 0; i < 3; i++)
        {
            BigInteger sum = 0;
            int N = int.Parse(Console.ReadLine());
            for(int j = 0; j < N; j++)
            {
                sum += BigInteger.Parse(Console.ReadLine());
            }
            if (sum == 0) Console.WriteLine(0);
            else if (sum < 0) Console.WriteLine("-");
            else if (sum > 0) Console.WriteLine("+");
        }
    }
}