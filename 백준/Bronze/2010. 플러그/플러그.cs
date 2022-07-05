using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 0; i < N; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine(sum - N + 1);
    }
}