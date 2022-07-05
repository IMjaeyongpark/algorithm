using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int S = int.Parse(s[0]);
        int T = int.Parse(s[1]);
        int D = int.Parse(s[2]);
        
        Console.WriteLine(D / (S * 2) * T);
    }
}