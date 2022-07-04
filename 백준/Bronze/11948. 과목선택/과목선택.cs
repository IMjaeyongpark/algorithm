using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int min = int.MaxValue;
        for (int i = 0; i < 4; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum += a;
            if(min > a) min = a;
        }
        sum -= min;
        min = int.MaxValue;
        for (int i = 0; i < 2; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum += a;
            if (min > a) min = a;
        }
        sum -= min;
        Console.WriteLine(sum);
    }
}