using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        Console.WriteLine(int.Parse(s[1]) - int.Parse(s[0]) + " " + s[1]);
    }
}