using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int T = int.Parse(s[1]);
        int C = int.Parse(s[2]);
        int P = int.Parse(s[3]);
        Console.WriteLine((N - 1)/ T * C * P);
    }
}