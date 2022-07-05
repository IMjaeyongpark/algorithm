using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[2]);
        int sum = int.Parse(s[4]);

        if (a + b == sum) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}