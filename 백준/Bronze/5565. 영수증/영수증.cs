using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < 9; i++)
        {
            N-=int.Parse(Console.ReadLine());
        }
        Console.WriteLine(N);
        
    }
}