using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        double a = double.Parse(s[0]) - double.Parse(s[0]) * double.Parse(s[1])/100.0;
        if (a >= 100.0) a = 0;
        else a = 1;
        Console.Write(a);
    }
}