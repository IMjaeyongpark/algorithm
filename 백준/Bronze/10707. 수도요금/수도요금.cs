using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int J = int.Parse(Console.ReadLine());

        x *= J;
        if (y2 < J)
        {
            y1 += (J - y2) * y3;
        }
        Console.WriteLine(x <= y1 ? x : y1);
    }
}