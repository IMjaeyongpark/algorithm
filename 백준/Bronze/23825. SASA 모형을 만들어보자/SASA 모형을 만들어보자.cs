using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        long N = long.Parse(s[0])/2;
        long M = long.Parse(s[1])/2;

        if (N > M) N = M;
        Console.WriteLine(N);
        
    }
}