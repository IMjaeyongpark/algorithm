using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int a = N - N * 20 / 100 * 22 / 100;
        Console.WriteLine(N*78/100+" "+ a);
    }
}