using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int count = 1;
        for(int i = 0; i < N; i++)
        {
            count *= 2;
        }
        Console.WriteLine(count);
        
    }
}