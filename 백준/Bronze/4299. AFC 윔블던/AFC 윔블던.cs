using System;


class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int h = int.Parse(s[0]);
        int c = int.Parse(s[1]);

        int a = h + c;
        int b = h - c;
        if (a % 2 == 0 && b % 2 == 0 && a >= 0 && b >= 0)
        {
            Console.WriteLine(a / 2 + " " + b / 2);
        }
        else Console.WriteLine(-1);
    }
}