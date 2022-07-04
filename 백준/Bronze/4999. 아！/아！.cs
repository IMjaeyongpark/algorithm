using System;

class Program
{
    static void Main()
    {
        char[] s1 = Console.ReadLine().ToCharArray();
        char[] s2 = Console.ReadLine().ToCharArray();
        if (s1.Length >= s2.Length) Console.WriteLine("go");
        else Console.WriteLine("no");
    }
}