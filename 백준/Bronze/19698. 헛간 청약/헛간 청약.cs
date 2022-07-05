using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int N = int.Parse(s[0]);
        int W = int.Parse(s[1]);
        int H = int.Parse(s[2]);
        int L = int.Parse(s[3]);
        int d = (int)(W / L) * (int)(H / L);
        if (d >= N) d = N;
        Console.WriteLine(d);

    }
}