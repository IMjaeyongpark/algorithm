using System;
using System.Text;
using System.Numerics;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            if (BigInteger.Parse(Console.ReadLine()) % 2 == 0) sb.Append("even\n");
            else sb.Append("odd\n");
        }
        Console.WriteLine(sb);
    }
}