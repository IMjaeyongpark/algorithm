using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        if (long.Parse(s[0]) == long.Parse(s[1])) Console.WriteLine(1);
        else Console.Write(0);

    }
}