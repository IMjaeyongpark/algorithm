using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int a = N % 8;
        if (a == 1) a = 1;
        else if (a == 2 || a == 0) a = 2;
        else if (a == 3 || a == 7) a = 3;
        else if (a == 4 || a == 6) a = 4;
        else if (a == 5) a = 5;
        Console.WriteLine(a);
    }
}