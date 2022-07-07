using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int n1 = int.Parse(s[0]);
        int k1 = int.Parse(s[1]);
        int n2 = int.Parse(s[2]);
        int k2 = int.Parse(s[3]);

        Console.WriteLine(n1 * k1 + n2 * k2);
    }
}