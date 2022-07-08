using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int sum = 56 * int.Parse(s[0]) + 24 * int.Parse(s[1]) + 14 * int.Parse(s[2]) + 6 * int.Parse(s[3]);
        Console.WriteLine(sum);


    }
}