using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double a = (double)N * (double)N * Math.PI;
        double b = (double)N * (double)N * 2.0;
        Console.WriteLine($"{a:0.000000}" + "\n" + $"{b:0.000000}");
    }
}