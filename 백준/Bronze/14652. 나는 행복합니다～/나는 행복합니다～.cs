using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        Console.WriteLine(int.Parse(s[2]) / M + " " + int.Parse(s[2]) % M);
    }
}