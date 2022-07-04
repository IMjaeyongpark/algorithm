using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        for(int i = 0; i < 5; i++)
        {
            int a=int.Parse(Console.ReadLine());
            if (a < 40) a = 40;
            sum += a;
        }
        Console.WriteLine(sum / 5);
    }
}