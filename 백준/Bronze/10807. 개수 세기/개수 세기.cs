using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        int V = int.Parse(Console.ReadLine());
        int count = 0;

        for(int i = 0; i < N; i++)
        {
            if (V == int.Parse(s[i])) count++;
        }
        Console.WriteLine(count);
    }
}