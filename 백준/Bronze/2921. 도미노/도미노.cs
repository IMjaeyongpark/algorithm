using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 1; i <= N; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                sum += j + i;
            }
        }
        Console.WriteLine(sum);
    }
}