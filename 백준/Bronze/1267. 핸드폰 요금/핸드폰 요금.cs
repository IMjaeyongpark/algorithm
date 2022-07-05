using System;

class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        long M = 0;
        long Y = 0;
        for(long i = 0; i < N; i++)
        {
            if (long.Parse(s[i]) != 0)
            {
                Y += ((long)(long.Parse(s[i])) / 30 + 1) * 10;
                M += ((long)(long.Parse(s[i])) / 60 + 1) * 15;
            }
        }
        long a = M <= Y ? M : Y;
        if (M >= Y) Console.Write("Y ");
        if (M <= Y) Console.Write("M ");
        Console.Write(a);
    }
}