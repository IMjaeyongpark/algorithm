using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int[] a = { int.Parse(s[0]), int.Parse(s[1]) };
        Console.WriteLine(a[1] * 2 - a[0]);
    }
}