using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string s = "CY";
        if (N % 2 == 0) s = "SK";
        Console.WriteLine(s);
    }
}