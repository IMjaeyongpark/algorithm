using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        
        for (BigInteger i = 0; i < N; i++)
        {
            Console.ReadLine();
            BigInteger sum = 0;
            BigInteger count = 0;
            int n1 = int.Parse(Console.ReadLine());
            for(int j = 0; j < n1; j++) { 
                string s = Console.ReadLine();
                if (s == "") break;
                sum += BigInteger.Parse(s);
                count++;
            }
            if (sum % count == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}