using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);

        int sum = (b - 1) / 4 - (a - 1) / 4;
        if (sum < 0) sum *= -1;

        int c = (b - 1) % 4 - (a - 1) % 4;
        if (c < 0) c *= -1;
        sum += c;
        Console.WriteLine(sum);
    }
}