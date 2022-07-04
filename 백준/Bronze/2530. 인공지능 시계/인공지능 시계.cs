using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int H = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int S = int.Parse(s[2]);

        int a = int.Parse(Console.ReadLine());

        S += a;
        M += S / 60;
        S %= 60;
        H += M / 60;
        M %= 60;
        H %= 24;
        Console.WriteLine(H + " " + M + " " + S);
    }
}