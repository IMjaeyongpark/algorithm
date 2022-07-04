using System;

class Program
{
    static void Main()
    {
        char[] c = Console.ReadLine().ToCharArray();
        Console.WriteLine(((int)c[0] - '가' + 1));
    }
}