using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        long M = long.Parse(s[0]) + long.Parse(s[1]);
        long C = long.Parse(Console.ReadLine());
        if (M < C*2) Console.WriteLine(M);
        else Console.WriteLine(M - C*2);
    }
}