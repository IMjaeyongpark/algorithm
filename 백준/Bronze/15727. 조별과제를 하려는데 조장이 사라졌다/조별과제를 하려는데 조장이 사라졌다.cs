using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int a = 0;
        a = N / 5;
        if (N % 5 != 0) a++;
        Console.WriteLine(a);
    }
}