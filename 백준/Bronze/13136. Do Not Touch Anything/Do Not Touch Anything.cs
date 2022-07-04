using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        long C = long.Parse(s[0]);
        long R = long.Parse(s[1]);
        long N = long.Parse(s[2]);

        long a = C / N;
        if (C % N != 0) a++;
        long b = R / N;
        if (R % N != 0) b++;
        Console.WriteLine(a * b);
    }
}