using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        long a = long.Parse(s[0]) * long.Parse(s[1]);
        Console.WriteLine(a/2);
    }
}